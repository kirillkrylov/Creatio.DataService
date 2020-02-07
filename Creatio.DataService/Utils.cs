using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Reflection;
using System.Reflection.Emit;
using Creatio.DataService.Attributes;
using Creatio.DataService.Parameters;
using System.Diagnostics;

namespace Creatio.DataService
{
    public class Utils : IDisposable
    {
        #region Fields
        private static volatile Utils _instance;
        private static readonly object _syncLock = new object();
        private bool BpmSessionId = false;
        private string domain;
        private string userName;
        private string password;
        private bool _IsLoginSuccess = false;
        #endregion

        #region Constructors
        private Utils() { }
        #endregion

        #region Properties
        public CookieContainer Auth { get; set; }
        public bool IsLoginSuccess { get { return _IsLoginSuccess; } }
        public CurrentUser CurrentUser { get; private set; } = null;
        public static Utils Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Utils();
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region Events
        public event EventHandler<WebSocketMessageReceivedEventArgs> WebSocketMessageReceived;
        #endregion

        #region Methods : Private
        private async void ConectWebSocket()
        {

            ClientWebSocket wss = new ClientWebSocket();
            wss.Options.Cookies = Instance.Auth;
            foreach (Cookie c in Instance.Auth.GetCookies(new Uri(domain)))
            {
                if (c.Name == "BPMCSRF" && !String.IsNullOrEmpty(c.Value))
                {
                    wss.Options.SetRequestHeader(c.Name, c.Value);
                    wss.Options.KeepAliveInterval = TimeSpan.FromSeconds(60);
                }
            }

            string socketDomain;
            if (domain.StartsWith("https://", StringComparison.Ordinal))
            {
                socketDomain = domain.Replace("https://", "wss://");
            }
            else
            {
                socketDomain = domain.Replace("http://", "ws://");
            }

            await wss.ConnectAsync(new Uri($"{socketDomain}/0/Nui/ViewModule.aspx.ashx"), CancellationToken.None).ConfigureAwait(false);
            while (wss.State == WebSocketState.Open)
            {
                ArraySegment<Byte> buffer = new ArraySegment<byte>(new Byte[8192]);
                WebSocketReceiveResult result;
                using (var ms = new MemoryStream())
                {
                    do
                    {
                        result = await wss.ReceiveAsync(buffer, CancellationToken.None).ConfigureAwait(false);
                        ms.Write(buffer.Array, buffer.Offset, result.Count);
                    }
                    while (!result.EndOfMessage);

                    ms.Seek(0, SeekOrigin.Begin);

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        using (var reader = new StreamReader(ms, Encoding.UTF8))
                        {
                            string txt = reader.ReadToEnd();
                            WebSocketMessageReceivedEventArgs e = JsonConvert.DeserializeObject<WebSocketMessageReceivedEventArgs>(txt);
                            Instance.OnWebSocketMessageReceived(e);
                        }
                    }
                }
            }
            wss.Dispose();
        }
        private void OnWebSocketMessageReceived(WebSocketMessageReceivedEventArgs e)
        {
            EventHandler<WebSocketMessageReceivedEventArgs> handler = WebSocketMessageReceived;
            handler?.Invoke(this, e);
        }
        /// <summary>
        /// Logs in with username and passowrd to the application and stores cookies in the container to use in the following requests
        /// <see cref="https://academy.creatio.com/documents/technic-sdk/7-15/authservicesvc-authentication-service"/>
        /// </summary>
        /// <param name="userName">Username to login</param>
        /// <param name="password">Password to login</param>
        /// <param name="domain">example https://work.creatio.com</param>
        /// <returns>Cookies to use in the following requests</returns>
        private CookieContainer AuthRequest(string userName, string password, string domain)
        {
            {
                if (domain.EndsWith("/", StringComparison.Ordinal))
                    domain = domain.Remove(domain.Length - 1, 1);

                CookieContainer AuthCookie = new CookieContainer();
                string authServiceUri = domain + @"/ServiceModel/AuthService.svc/Login";

                HttpWebRequest authRequest = (HttpWebRequest)WebRequest.Create(authServiceUri);
                authRequest.Method = "POST";
                authRequest.ContentType = "application/json";
                authRequest.CookieContainer = AuthCookie;
                using (var requestStream = authRequest.GetRequestStream())
                {
                    using (StreamWriter writer = new StreamWriter(requestStream))
                    {
                        writer.Write(@"{
                    ""UserName"":""" + userName + @""",
                    ""UserPassword"":""" + password + @"""
                    }");
                    }
                }
                using (HttpWebResponse myHttpWebResponse = (HttpWebResponse)authRequest.GetResponse())
                {
                    HttpStatusCode status = myHttpWebResponse.StatusCode;
                    using (StreamReader MyStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream(), true))
                    {
                        string response = MyStreamReader.ReadToEnd();
                        JObject jsonResponse = JObject.Parse(response);
                        Dictionary<string, string> results = new Dictionary<string, string>();

                        foreach (KeyValuePair<string, JToken> item in jsonResponse)
                        {
                            results.Add(item.Key, item.Value.ToString());
                        }
                        if (results["Code"] == "0")
                        {
                            AuthCookie.Add(myHttpWebResponse.Cookies);
                            Instance._IsLoginSuccess = true;
                            return AuthCookie;
                        }
                        else
                        {
                            throw new CreationException("Login Failed");
                            //throw new Exception("Login failed");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Gets SysValues provided in ViewModule.aspx
        /// </summary>
        /// <returns>Current User</returns>
        /// <remarks>
        private async Task<CurrentUser> GetSysValuesAsync()
        {
            string transportResponse;
            string transportUrl = Instance.domain + @"/0/Nui/ViewModule.aspx";
            HttpStatusCode Code;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(transportUrl);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/html; charset=utf-8";
            myHttpWebRequest.CookieContainer = Instance.Auth;

            CurrentUser currentUser = new CurrentUser();
            try
            {
                using (HttpWebResponse myHttpWebResponse = (HttpWebResponse)await myHttpWebRequest.GetResponseAsync().ConfigureAwait(false))
                {
                    Code = myHttpWebResponse.StatusCode;
                    if (Instance.BpmSessionId == false)
                    {
                        string val = myHttpWebResponse.Cookies["BPMSESSIONID"].Value;
                        Cookie C = new Cookie("BPMSESSIONID", val);
                        Instance.Auth.Add(new Uri(Instance.domain), C);
                        Instance.BpmSessionId = true;
                    }
                    using (StreamReader MyStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream(), true))
                    {
                        transportResponse = MyStreamReader.ReadToEnd();

                        HtmlDocument doc = new HtmlDocument();
                        doc.LoadHtml(transportResponse);

                        HtmlNodeCollection head = doc.DocumentNode.ChildNodes["html"].ChildNodes["head"].ChildNodes;
                        for (int i = 0; i < head.Count; i++)
                        {
                            HtmlNode node = head[i];
                            if (node.Name == "script")
                            {
                                if (node.InnerText.StartsWith("\r\nvar sysValues = {CURRENT_USER", StringComparison.Ordinal))
                                {
                                    string myText = node.InnerText;
                                    string[] values = myText.Split(';');
                                    for (int v = 0; v < values.Length; v++)
                                    {
                                        if (values[v].StartsWith("\r\nvar sysValues", StringComparison.Ordinal))
                                        {
                                            string settings = values[v].Split('=')[1];
                                            currentUser = JsonConvert.DeserializeObject<CurrentUser>(settings);
                                            currentUser.Code = Code;
                                            currentUser.ErrorMessage = "";
                                            return currentUser;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (WebException we)
            {
                Code = ((HttpWebResponse)(we).Response).StatusCode;
                using (StreamReader MyStreamReader = new StreamReader(((HttpWebResponse)(we).Response).GetResponseStream(), true))
                {
                    transportResponse = MyStreamReader.ReadToEnd();
                    currentUser = new CurrentUser()
                    {
                        ErrorMessage = transportResponse,
                        Code = Code
                    };
                }
            }
            return currentUser;
        }
        private SelectQuery BuildSelectRequest(QueryParameters queryParameters, List<QueryColumn> queryColumns)
        {
            SelectQuery selectQuery = new SelectQuery()
            {
                RootSchemaName = queryParameters.RootSchemaName,
                UseLocalization = queryParameters.UseLocalization,
                AllColumns = queryParameters.AllColumns,
                QuerySource = Enums.QuerySource.Filter
            };
            SelectQueryColumns Columns = new SelectQueryColumns();
            Dictionary<string, SelectQueryColumn> Items = new Dictionary<string, SelectQueryColumn>();
            foreach (QueryColumn qc in queryColumns) {
                SelectQueryColumn col = new SelectQueryColumn()
                {
                    OrderDirection = qc.OrderDirection,
                    OrderPosition = qc.OrderPosition,
                    Expression = new ColumnExpression()
                    {
                        ExpressionType = qc.ExpressionType,
                        ColumnPath = qc.ColumnPath
                    }
                };
                Items.Add(qc.Caption, col);
            }
            Columns.Items = Items;
            selectQuery.Columns = Columns;
            return selectQuery;
        }
        private Filters BuildFilterById(Guid id) {

            Filters filter = new Filters()
            {
                // Filter type is group.
                FilterType = Enums.FilterType.FilterGroup,
                // Filters collection.
                LogicalOperation = Enums.LogicalOperationStrict.And,
                Items = new Dictionary<string, Filter>()
                {
                    {
                        "Id", new Filter
                        {
                            FilterType = Enums.FilterType.CompareFilter,
                            ComparisonType = Enums.FilterComparisonType.Equal,
                            LeftExpression = new BaseExpression()
                            {
                                ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                ColumnPath = "Id"
                            },
                            RightExpression = new BaseExpression()
                            {
                                ExpressionType = Enums.EntitySchemaQueryExpressionType.Parameter,
                                Parameter = new Parameter()
                                {
                                    DataValueType = Enums.DataValueType.Guid,
                                    Value = id
                                }
                            }
                        }
                    }
                }
            };
            return filter;
        }
        private Filters BuildFilterByParent(Guid parentId, string parentColumnName)
        {
            Filters filter = new Filters()
            {
                // Filter type is group.
                FilterType = Enums.FilterType.FilterGroup,
                // Filters collection.
                LogicalOperation = Enums.LogicalOperationStrict.And,
                Items = new Dictionary<string, Filter>()
                {
                    {
                        "Id", new Filter
                        {
                            FilterType = Enums.FilterType.CompareFilter,
                            ComparisonType = Enums.FilterComparisonType.Equal,
                            LeftExpression = new BaseExpression()
                            {
                                ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                ColumnPath = parentColumnName
                            },
                            RightExpression = new BaseExpression()
                            {
                                ExpressionType = Enums.EntitySchemaQueryExpressionType.Parameter,
                                Parameter = new Parameter()
                                {
                                    DataValueType = Enums.DataValueType.Guid,
                                    Value = parentId
                                }
                            }
                        }
                    }
                }
            };
            return filter;
        }
        private DataTable ConvertResponseToDataTable(string json)
        {
            DataServiceSelectResponseTemplate myResponse = JsonConvert.DeserializeObject<DataServiceSelectResponseTemplate>(json);
            DataTable dt = new DataTable();
            foreach (KeyValuePair<string, JToken> keyValuePair in myResponse.RowConfig)
            {
                string myKey = keyValuePair.Key.ToString(null);
                if (true)
                {
                    JToken prop = myResponse.RowConfig[myKey];
                    string PotentialProperty = prop["dataValueType"].ToString();
                    DataColumn dc = new DataColumn(myKey);
                    int.TryParse(PotentialProperty, out int propNum);
                    Enums.DataValueType dtv = (Enums.DataValueType)propNum;
                    switch (dtv)
                    {
                        case Enums.DataValueType.Guid:
                            dc.DataType = typeof(Guid);
                            break;
                        case Enums.DataValueType.Text:
                            dc.DataType = typeof(string);
                            break;
                        case Enums.DataValueType.Integer:
                            dc.DataType = typeof(int);
                            break;
                        case Enums.DataValueType.Float:
                            dc.DataType = typeof(float);
                            break;
                        case Enums.DataValueType.Money:
                            dc.DataType = typeof(decimal);
                            break;
                        case Enums.DataValueType.DateTime:
                            dc.DataType = typeof(DateTime);
                            break;
                        case Enums.DataValueType.Date:
                            dc.DataType = typeof(DateTime);
                            break;
                        case Enums.DataValueType.Time:
                            dc.DataType = typeof(DateTime);
                            break;
                        case Enums.DataValueType.Lookup:
                            dc.DataType = typeof(string);
                            break;
                        case Enums.DataValueType.Enum:
                            dc.DataType = typeof(string);
                            break;
                        case Enums.DataValueType.Boolean:
                            dc.DataType = typeof(bool);
                            break;
                        case Enums.DataValueType.Blob:
                            dc.DataType = typeof(byte[]);
                            break;
                        case Enums.DataValueType.Image:
                            dc.DataType = typeof(string);
                            break;
                        case Enums.DataValueType.ImageLookup:
                            dc.DataType = typeof(string);
                            break;
                        case Enums.DataValueType.Color:
                            dc.DataType = typeof(string);
                            break;
                        case Enums.DataValueType.Mapping:
                            dc.DataType = typeof(string);
                            break;
                        default:
                            dc.DataType = typeof(string);
                            break;
                    }
                    dt.Columns.Add(dc);
                }
            }
            foreach (JToken row in myResponse.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (JToken item in row)
                {
                    JProperty jp = (JProperty)item;

                    string PropName = jp.Name;

                    if (dt.Columns.Contains(jp.Name))
                    {
                        JToken prop = myResponse.RowConfig[PropName];
                        string dataValueType = prop["dataValueType"].ToString();

                        int.TryParse(dataValueType, out int propNum);
                        Enums.DataValueType dtv = (Enums.DataValueType)propNum;
                        string PropValue = jp.Value.ToString();

                        switch (dtv)
                        {
                            case Enums.DataValueType.Guid:
                                if (!Guid.TryParse(PropValue, out Guid pGuid))
                                {
                                    dr[PropName] = DBNull.Value;
                                }
                                else
                                {
                                    dr[PropName] = pGuid;
                                }
                                break;
                            case Enums.DataValueType.SecureText:
                            case Enums.DataValueType.HashText:
                            case Enums.DataValueType.LongText:
                            case Enums.DataValueType.MaxSizeText:
                            case Enums.DataValueType.MediumText:

                            case Enums.DataValueType.ShortText:
                            case Enums.DataValueType.Text:
                                dr[PropName] = PropValue;
                                break;
                            case Enums.DataValueType.Integer:
                                if (int.TryParse(PropValue, out int pInt))
                                {
                                    dr[PropName] = pInt;
                                }
                                else
                                {
                                    dr[PropName] = DBNull.Value;
                                }
                                break;
                            case Enums.DataValueType.Float1:
                            case Enums.DataValueType.Float2:
                            case Enums.DataValueType.Float3:
                            case Enums.DataValueType.Float4:
                            case Enums.DataValueType.Float8:
                            case Enums.DataValueType.Float:
                            case Enums.DataValueType.Money:
                                if (decimal.TryParse(PropValue, out decimal pDec))
                                {
                                    dr[PropName] = pDec;
                                }
                                else
                                {
                                    dr[PropName] = DBNull.Value;
                                }
                                break;

                            case Enums.DataValueType.DateTime:
                            case Enums.DataValueType.Date:
                            case Enums.DataValueType.Time:
                                if (DateTime.TryParse(PropValue, out DateTime pDateTime))
                                {
                                    dr[PropName] = pDateTime;
                                }
                                else
                                {
                                    dr[PropName] = DBNull.Value;
                                }
                                break;

                            case Enums.DataValueType.ImageLookup:
                            case Enums.DataValueType.Lookup:
                                dr[PropName] = (!string.IsNullOrEmpty(PropValue)) ? JsonConvert.DeserializeObject<LookupColumnValue>(PropValue).Value : "";
                                break;
                            case Enums.DataValueType.Enum:

                                break;
                            case Enums.DataValueType.Boolean:
                                if (int.TryParse(PropValue, out int pInt2))
                                {
                                    dr[PropName] = (pInt2 == 1) ? true : false;
                                }
                                else
                                {
                                    dr[PropName] = DBNull.Value;
                                }
                                break;
                            case Enums.DataValueType.File:
                                //byte[] fb = Encoding.ASCII.GetBytes(PropValue);
                                dr[PropName] = DBNull.Value;
                                break;
                            case Enums.DataValueType.Blob:
                                //byte[] bb = Encoding.ASCII.GetBytes(PropValue);
                                dr[PropName] = DBNull.Value;
                                break;
                            case Enums.DataValueType.Image:
                                dr[PropName] = PropValue;
                                break;
                            case Enums.DataValueType.Color:
                                dr[PropName] = DBNull.Value;
                                break;
                            case Enums.DataValueType.Mapping:
                                dr[PropName] = DBNull.Value;
                                break;
                            case Enums.DataValueType.Object:
                            case Enums.DataValueType.ValueList:
                            case Enums.DataValueType.LocalizableParameterValuesListDataValueType:
                            case Enums.DataValueType.EntityDataValueType:
                            case Enums.DataValueType.EntityCollectionDataValueType:
                            case Enums.DataValueType.EntityColumnMappingCollectionDataValueType:
                            case Enums.DataValueType.MetaDataTextDataValueType:
                            case Enums.DataValueType.ObjectList:
                            case Enums.DataValueType.CompositeObjectList:
                                dr[PropName] = DBNull.Value;
                                break;
                            default:
                                dr[PropName] = PropValue;
                                break;
                        }
                    }
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private List<Entity> BuildEntity<Entity>(RequestResponse requestResponse) where Entity : BaseEntity, new()
        {
            List<Entity> result = new List<Entity>();
            DataTable dt = ConvertResponseToDataTable(requestResponse.Result);
            foreach (DataRow dr in dt.Rows)
            {
                Entity entity = EntityFacotry.Create<Entity>();
                foreach (PropertyInfo prop in entity.GetType().GetProperties())
                {
                    string strValue = string.Empty;
                    if (dt.Columns.Contains(prop.Name))
                    {
                        strValue = dr[prop.Name].ToString();
                    
                        //setting ValueProperties
                        CPropertyAttribute propertyAttribute = prop.GetCustomAttribute<CPropertyAttribute>(true);
                        if (propertyAttribute != null && propertyAttribute.ColumnPath != null)
                        {
                            switch (prop.PropertyType.Name)
                            {
                                case (nameof(Guid)):
                                    Guid.TryParse(strValue, out Guid val);
    #if DEBUG
                                    //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
    #endif
                                    prop.SetValue(entity, val);
                                    break;

                                case (nameof(Decimal)):
                                    decimal.TryParse(strValue, out decimal decVal);
    #if DEBUG
                                    //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
    #endif

                                    prop.SetValue(entity, decVal);
                                    break;

                                case (nameof(Int16)):
                                case (nameof(Int32)):
                                case (nameof(Int64)):
                                    int.TryParse(strValue, out int intVal);
    #if DEBUG
                                    //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
    #endif                                
                                    prop.SetValue(entity, intVal);
                                    break;

                                case (nameof(DateTime)):
                                    DateTime.TryParse(strValue, out DateTime dateTimeVal);
    #if DEBUG
                                    //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
    #endif
                                    prop.SetValue(entity, dateTimeVal);
                                    break;

                                case (nameof(String)):
                                    prop.SetValue(entity, strValue);
    #if DEBUG
                                    //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
    #endif
                                    break;
                            }
                        }

                        //setting up Navigational properties
                        if (propertyAttribute?.Navigation != null)
                        {
                            //1. Create Object
                            var subEntity = Activator.CreateInstance(prop.PropertyType);

                            //2. Get subEntity's Id;
                            string navKey = propertyAttribute?.Navigation; // navKey = Account:AccountId

                            if (navKey.Contains(":"))
                            {
                                string col = navKey.Split(':')[1]; //col = AccountI
                                Guid.TryParse(dr[col].ToString(), out Guid subId); //assume that the key is always Guid

                                //3. Set subEntity's Key;
                                string key = GetSubEntityKeyColumn(subEntity);
                                subEntity.GetType().GetProperty(key).SetValue(subEntity, subId);

                                //4. Set entity property to subEntity
                                prop.SetValue(entity, subEntity);
                            }

                        }
                    }
                }
                result.Add(entity);
            }
            return result;
        }
        private List<Entity> BuildEntity2<Entity>(RequestResponse requestResponse) where Entity : BaseEntity, new()
        {
            List<Entity> result = new List<Entity>();
            DataTable dt = ConvertResponseToDataTable(requestResponse.Result);
            foreach (DataRow dr in dt.Rows)
            {
                Entity entity = EntityFacotry.Create<Entity>();
                foreach (PropertyInfo prop in entity.GetType().GetProperties())
                {
                    string strValue = string.Empty;
                    try
                    {
                        strValue = dr[prop.Name]?.ToString();
                    }
                    catch (Exception e)
                    {
#if DEBUG
                        //Console.WriteLine($"Utils.cs Line 409: {e.Message}");
#endif
                    }

                    //setting ValueProperties
                    CPropertyAttribute propertyAttribute = prop.GetCustomAttribute<CPropertyAttribute>(true);
                    if (propertyAttribute != null && propertyAttribute.ColumnPath != null)
                    {
                        switch (prop.PropertyType.Name)
                        {
                            case (nameof(Guid)):
                                Guid.TryParse(strValue, out Guid val);
#if DEBUG
                                //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
#endif
                                prop.SetValue(entity, val);
                                break;

                            case (nameof(Decimal)):
                                decimal.TryParse(strValue, out decimal decVal);
#if DEBUG
                                //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
#endif

                                prop.SetValue(entity, decVal);
                                break;

                            case (nameof(Int16)):
                            case (nameof(Int32)):
                            case (nameof(Int64)):
                                int.TryParse(strValue, out int intVal);
#if DEBUG
                                //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
#endif                                
                                prop.SetValue(entity, intVal);
                                break;

                            case (nameof(DateTime)):
                                DateTime.TryParse(strValue, out DateTime dateTimeVal);
#if DEBUG
                                //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
#endif
                                prop.SetValue(entity, dateTimeVal);
                                break;

                            case (nameof(String)):
                                prop.SetValue(entity, strValue);
#if DEBUG
                                //Console.WriteLine($"Setting {prop.Name} of Type:{prop.PropertyType.Name} to value of {strValue}");
#endif
                                break;
                        }
                    }

                    //setting up Navigational properties
                    if (propertyAttribute?.Navigation != null)
                    {
                        //1. Create Object
                        var subEntity = Activator.CreateInstance(prop.PropertyType);

                        //2. Get subEntity's Id;
                        string navKey = propertyAttribute?.Navigation; // navKey = Account:AccountId

                        if (navKey.Contains(":"))
                        {
                            string col = navKey.Split(':')[1]; //col = AccountI
                            Guid.TryParse(dr[col].ToString(), out Guid subId); //assume that the key is always Guid

                            //3. Set subEntity's Key;
                            string key = GetSubEntityKeyColumn(subEntity);
                            subEntity.GetType().GetProperty(key).SetValue(subEntity, subId);

                            //4. Set entity property to subEntity
                            prop.SetValue(entity, subEntity);
                        }

                    }

                }
                result.Add(entity);
            }
            return result;
        }
        private string GetSubEntityKeyColumn(object subEntity) {
            string result = string.Empty;

            PropertyInfo[] props = subEntity.GetType().GetProperties();
            foreach (PropertyInfo subProprty in props)
            {
                if (subProprty.GetCustomAttribute<CPropertyAttribute>()?.IsKey == true) {
                    return subProprty.Name;
                }
            }
            return result;
        }
        private QueryParameters BuildQueryParameters<Entity>() where Entity : BaseEntity, new()
        {
            Entity entity = EntityFacotry.Create<Entity>();
            CObjectAttribute rootSchemaNameAttribute = entity.GetType().GetCustomAttribute<CObjectAttribute>(true);
            QueryParameters queryParameters = new QueryParameters()
            {
                RootSchemaName = rootSchemaNameAttribute.RootSchemaName,
                AllColumns = false,
                UseLocalization = false
            };
            return queryParameters;
        }
        private List<QueryColumn> BuildQueryColumns<Entity>() where Entity : BaseEntity, new()
        {
            Entity entity = EntityFacotry.Create<Entity>();
            List<QueryColumn> queryColumns = new List<QueryColumn>();
            foreach (PropertyInfo propInfo in entity.GetType().GetProperties())
            {
                string caption = propInfo.Name;
                CPropertyAttribute propertyAttribute = propInfo.GetCustomAttribute<CPropertyAttribute>(true);
                if (propertyAttribute != null && propertyAttribute.ColumnPath != null)
                {
                    QueryColumn qc = new QueryColumn()
                    {
                        Caption = caption,
                        ColumnPath = GetNewColumnPath(entity, propertyAttribute.ColumnPath),
                        ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                        OrderDirection = Enums.OrderDirection.None,
                        OrderPosition = 0,
                    };
                    queryColumns.Add(qc);
                }
            }
            return queryColumns;
        }
        private async Task<RequestResponse> GetResponseAsync(string json, ActionEnum method)
        {
            string transportUrl = Url.TransportUrl(method, Instance.domain);
            HttpStatusCode Code;
            RequestResponse result = new RequestResponse();
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(transportUrl);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.ContentType = "application/json";
            myHttpWebRequest.CookieContainer = Instance.Auth;

            Uri siteUri = new Uri(transportUrl);
            foreach (Cookie cookie in Instance.Auth.GetCookies(siteUri))
            {
                if (cookie.Name == "BPMCSRF" || cookie.Name == "BPMSESSIONID")
                {
                    myHttpWebRequest.Headers.Add(cookie.Name, cookie.Value);
                }
            }
            //encode json
            byte[] postBytes = Encoding.UTF8.GetBytes(json);
            //Prepare Request Stream
            using (Stream requestStream = myHttpWebRequest.GetRequestStream())
            {
                requestStream.Write(postBytes, 0, postBytes.Length);
            }
            //Send Request
            try
            {
                using (HttpWebResponse myHttpWebResponse = (HttpWebResponse)await myHttpWebRequest.GetResponseAsync().ConfigureAwait(false))
                {
                    Code = myHttpWebResponse.StatusCode;
                    /***
                    * !!! VERY IMPORTANT !!!
                    * READ: https://academy.bpmonline.com/documents/technic-sdk/7-14/executing-odata-queries-using-fiddler
                    * User session is created only upon the first request to the EntityDataService.svc, after which the BPMSESSIONID cookie will be returned in the response. 
                    * Therefore, there is no need to add BPMSESSIONID cookie to the title of the first request.
                    * If you do not add BPMSESSIONID cookie to each subseqnent request, then each request will create a new user session. 
                    * Significant frequency of requests (several or more requests a minute) will increase the RAM consumption which will decrease performance.
                    */
                    if (Instance.BpmSessionId == false)
                    {
                        //Auth.Add(myHttpWebResponse.Cookies);
                        string val = myHttpWebResponse.Cookies["BPMSESSIONID"].Value;
                        Cookie C = new Cookie("BPMSESSIONID", val);
                        Instance.Auth.Add(new Uri(Instance.domain), C);
                        Instance.BpmSessionId = true;
                    }
                    using (StreamReader MyStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream(), true))
                    {
                        result.HttpStatusCode = Code;
                        result.Result = MyStreamReader.ReadToEnd();
                        result.ErrorMessage = null;
                    }
                }
            }
            catch (WebException we)
            {
                Code = ((HttpWebResponse)(we).Response).StatusCode;
                using (StreamReader MyStreamReader = new StreamReader(((HttpWebResponse)(we).Response).GetResponseStream(), true))
                {
                    result.HttpStatusCode = Code;
                    result.Result = null;
                    result.ErrorMessage = MyStreamReader.ReadToEnd();
                }
            }
            return result;
        }
        /// <summary>
        /// Returns new columns path if column is found in navigational property 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="oldColumnPath"></param>
        /// <returns>REDO - Highly inefficient</returns>
        private string GetNewColumnPath(object entity, string oldColumnPath) 
        {

            List<PropertyInfo> vProps = new List<PropertyInfo>();
            List<PropertyInfo> nProps = new List<PropertyInfo>();

            foreach (PropertyInfo pInfo in entity.GetType().GetProperties())
            {
                CPropertyAttribute pAttr = pInfo.GetCustomAttribute<CPropertyAttribute>(true);
                if (pAttr?.ColumnPath != null) vProps.Add(pInfo);
                if (pAttr?.Navigation != null) nProps.Add(pInfo);
            }

            foreach (PropertyInfo pInfo in nProps)
            {
                //nav = "Account:AccountId"
                string nav = pInfo.GetCustomAttribute<CPropertyAttribute>().Navigation;
                string searchObj = nav.Split(':')[0]; //Account
                string searchCol = nav.Split(':')[1]; //AccountId

                if (searchCol == oldColumnPath)
                {
                    return $"{searchCol.Substring(0, searchCol.Length - 2)}";
                    //return $"{searchObj}.Id";
                }
            }
            return oldColumnPath;
        }
        #endregion


        #region Methods : Public

        /// <summary>
        /// Sets credentials to use for initial Authentication
        /// </summary>
        /// <param name="UserName">Username to Login with</param>
        /// <param name="Password">Password to Login with</param>
        /// <param name="Domain">Application Url i.e. (https://0123456-studio.creatio.com)</param>
        public void SetCredentials(string UserName, string Password, string Domain)
        {
            Instance.userName = (!string.IsNullOrEmpty(UserName)) ? UserName : "Supervisor";
            Instance.password = (!string.IsNullOrEmpty(Password)) ? Password : "Supervisor";
            Instance.domain = (!string.IsNullOrEmpty(Domain)) ? Domain : "https://work.creatio.com";
        }

        /// <summary>
        /// Logs in and requests Current User info
        /// </summary>
        /// <returns>Authentication result</returns>
        public async Task<bool> LoginAsync()
        {
            Auth = AuthRequest(Instance.userName, Instance.password, Instance.domain);
            if (Instance._IsLoginSuccess)
            {
                Instance.CurrentUser = await GetSysValuesAsync().ConfigureAwait(false);
                Instance.ConectWebSocket();
            }
            return Instance._IsLoginSuccess;
        }

        public async Task<bool> LogoutAsync()
        {
            var logout = await GetResponseAsync("{}", ActionEnum.LOGOUT).ConfigureAwait(false);
            if (logout.HttpStatusCode == HttpStatusCode.OK)
            {
                Auth = null;
                Instance.BpmSessionId = false;
                Instance.CurrentUser = null;
                Instance._IsLoginSuccess = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns object containing Base64 encoded Images.
        /// </summary>
        /// <param name="id">Id of the Image in SysImage Table</param>
        /// <returns>Base64 encoded image or error message</returns>
        public async Task<RequestResponse> GetImageAsync(string id)
        {
            string transportUrl = Url.TransportUrl(ActionEnum.SYSIMAGE, Instance.domain) + id;
            HttpStatusCode Code;

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(transportUrl);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "application/octet-stream";
            myHttpWebRequest.CookieContainer = Auth;

            Uri siteUri = new Uri(transportUrl);
            foreach (Cookie cookie in Auth.GetCookies(siteUri))
            {
                if (cookie.Name == "BPMCSRF" || cookie.Name == "BPMSESSIONID")
                {
                    myHttpWebRequest.Headers.Add(cookie.Name, cookie.Value);
                }
            }
            //Send Request
            try
            {
                using (HttpWebResponse myHttpWebResponse = (HttpWebResponse)await myHttpWebRequest.GetResponseAsync().ConfigureAwait(false))
                {
                    Code = myHttpWebResponse.StatusCode;
                    if (Instance.BpmSessionId == false)
                    {
                        string val = myHttpWebResponse.Cookies["BPMSESSIONID"].Value;
                        Cookie C = new Cookie("BPMSESSIONID", val);
                        Auth.Add(new Uri(Instance.domain), C);
                        Instance.BpmSessionId = true;
                    }
                    using (Stream myStream = myHttpWebResponse.GetResponseStream())
                    {
                        //Stream str = myHttpWebResponse.GetResponseStream();
                        byte[] inBuf = new byte[myHttpWebResponse.ContentLength];
                        int bytesToRead = (int)inBuf.Length;
                        int bytesRead = 0;
                        while (bytesToRead > 0)
                        {
                            int n = myStream.Read(inBuf, bytesRead, bytesToRead);
                            if (n == 0)
                                break;
                            bytesRead += n;
                            bytesToRead -= n;
                        }
                        string PhotoData = Convert.ToBase64String(inBuf);
                        myStream.Close();
                        myStream.Dispose();

                        RequestResponse ir = new RequestResponse()
                        {
                            HttpStatusCode = Code,
                            Result = PhotoData,
                            ErrorMessage = null
                        };
                        return ir;
                    }
                }
            }
            catch (WebException we)
            {
                Code = ((HttpWebResponse)(we).Response).StatusCode;
                using (StreamReader MyStreamReader = new StreamReader(((HttpWebResponse)(we).Response).GetResponseStream(), true))
                {
                    return new RequestResponse()
                    {
                        HttpStatusCode = Code,
                        Result = null,
                        ErrorMessage = MyStreamReader.ReadToEnd()
                    };
                }
            }
        }

        /// <summary></summary>
        /// <code>List<Contact> CurrentUser = await utils.Select<Contact>(ContactId)</code>
        /// <typeparam name="Entity">Entity Model</typeparam>
        /// <param name="id">Entity.Id</param>
        /// <returns>List of entities</returns>
        public async Task<List<Entity>> Select<Entity>(string id = "") where Entity : BaseEntity, new()
        {
            QueryParameters queryParameters = BuildQueryParameters<Entity>();
            List<QueryColumn> queryColumns = BuildQueryColumns<Entity>();
            SelectQuery selectQuery = BuildSelectRequest(queryParameters, queryColumns);
            
            if (!string.IsNullOrEmpty(id)) 
            {
                Filters filterById = BuildFilterById(Guid.Parse(id));
                selectQuery.Filters = filterById;
            }
       
            string selectQueryJson = JsonConvert.SerializeObject(selectQuery);
            RequestResponse requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT);

            if (!string.IsNullOrEmpty(requestResponse.ErrorMessage))
            {
                return new List<Entity>();
            }

            List<Entity> result = BuildEntity<Entity>(requestResponse);
            return result;
        }


        public async Task<List<Entity>> SelectAssociation<Entity>(string parentId = "", string childColumnName="") where Entity : BaseEntity, new()
        {
            QueryParameters queryParameters = BuildQueryParameters<Entity>();
            List<QueryColumn> queryColumns = BuildQueryColumns<Entity>();
            SelectQuery selectQuery = BuildSelectRequest(queryParameters, queryColumns);

            if (!string.IsNullOrEmpty(parentId))
            {
                Filters filterById = BuildFilterByParent(Guid.Parse(parentId), childColumnName);
                selectQuery.Filters = filterById;

            }

            string selectQueryJson = JsonConvert.SerializeObject(selectQuery);
            RequestResponse requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT);

            if (!string.IsNullOrEmpty(requestResponse.ErrorMessage)) {
                return new List<Entity>();
            }

            List<Entity> result = BuildEntity<Entity>(requestResponse);
            return result;
        }

        public async Task<List<Entity>> SelectList<Entity>(string childColumnName, Guid parentId = new Guid()) where Entity : BaseEntity, new()
        {
            Entity entity = EntityFacotry.Create<Entity>();
            QueryParameters queryParameters = BuildQueryParameters<Entity>();
            
#region QueryColumns

            

            List<QueryColumn> QueryColumns = new List<QueryColumn>();
            foreach (PropertyInfo propInfo in entity.GetType().GetProperties())
            {
                string caption = propInfo.Name;
                QueryColumnAttribute qca = propInfo.GetCustomAttribute<QueryColumnAttribute>(true);
                if (qca != null)
                {
                    QueryColumn qc = new QueryColumn()
                    {
                        Caption = caption,
                        ColumnPath = qca.ColumnPath,
                        ExpressionType = qca.ExpressionType,
                        OrderDirection = qca.OrderDirection,
                        OrderPosition = qca.OrderPosition,
                    };
                    QueryColumns.Add(qc);
                }

                RootSchemaNameAttribute ra = propInfo.GetCustomAttribute<RootSchemaNameAttribute>(true);
                if (ra != null)
                {
                    //nestedObjects.Add(caption, ra.RootSchemaName);

                    QueryColumn qc = new QueryColumn()
                    {
                        Caption = caption,
                        ColumnPath = caption,
                        ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                    };
                    QueryColumns.Add(qc);
                }
            }
#endregion

            SelectQuery selectQ = BuildSelectRequest(queryParameters, QueryColumns);
            if (parentId!=Guid.Empty)
            {
                Filters filterById = BuildFilterByParent(parentId, childColumnName);
                selectQ.Filters = filterById;
            }

            //string json = string.Empty;
            string json = JsonConvert.SerializeObject(selectQ);
            RequestResponse requestResponse = await GetResponseAsync(json, ActionEnum.SELECT);

            List<Entity> result = BuildEntity<Entity>(requestResponse);

            return result;
        }


#region Experimental

        private List<QueryColumn> GetDeepEntityColumns(object deepEntity)
        {

            //Console.WriteLine(deepEntity.GetType().FullName);
            List<QueryColumn> queryColumns = new List<QueryColumn>();
            foreach (PropertyInfo propInfo in deepEntity.GetType().GetProperties())
            {
                string caption = $"{deepEntity.GetType().Name}.{propInfo.Name}";
                Console.WriteLine(caption);

                QueryColumnAttribute qca = propInfo.GetCustomAttribute<QueryColumnAttribute>(true);
                if (qca != null)
                {
                    QueryColumn qc = new QueryColumn()
                    {
                        Caption = caption,
                        ColumnPath = caption,
                        ExpressionType = qca.ExpressionType,
                        OrderDirection = qca.OrderDirection,
                        OrderPosition = qca.OrderPosition,
                    };
                    queryColumns.Add(qc);
                }


                RootSchemaNameAttribute ra = propInfo.GetCustomAttribute<RootSchemaNameAttribute>(true);
                if (ra != null)
                {
                    Type[] types = propInfo.PropertyType.GetInterfaces();
                    var index = Array.FindIndex(types, x => x.Name == "IEnumerable");
                    if (index == -1)//Not a list
                    {
                        var ddeepEntity = Activator.CreateInstance(propInfo.PropertyType);
                        queryColumns.AddRange(GetDeepEntityColumns(ddeepEntity));
                    }
                }
            }

            return queryColumns;
        }
        private Filters BuildFilterByParentId(Guid id, string parentReference)
        {

            Filters filter = new Filters()
            {
                // Filter type is group.
                FilterType = Enums.FilterType.FilterGroup,
                // Filters collection.
                LogicalOperation = Enums.LogicalOperationStrict.And,
                Items = new Dictionary<string, Filter>()
                {
                    {
                        "ByParentId", new Filter
                        {
                            FilterType = Enums.FilterType.CompareFilter,
                            ComparisonType = Enums.FilterComparisonType.Equal,
                            LeftExpression = new BaseExpression()
                            {
                                ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                ColumnPath = parentReference
                            },
                            RightExpression = new BaseExpression()
                            {
                                ExpressionType = Enums.EntitySchemaQueryExpressionType.Parameter,
                                Parameter = new Parameter()
                                {
                                    DataValueType = Enums.DataValueType.Guid,
                                    Value = id
                                }
                            }
                        }
                    }
                }
            };
            return filter;
        }
        private List<QueryColumn> BuildDeeperQueryColumns<Entity>() where Entity : BaseEntity, new()
        {
            Entity entity = EntityFacotry.Create<Entity>();
            List<QueryColumn> queryColumns = new List<QueryColumn>();

            foreach (PropertyInfo propInfo in entity.GetType().GetProperties())
            {
                string caption = propInfo.Name;
                QueryColumnAttribute qca = propInfo.GetCustomAttribute<QueryColumnAttribute>(true);
                if (qca != null)
                {
                    QueryColumn qc = new QueryColumn()
                    {
                        Caption = caption,
                        ColumnPath = qca.ColumnPath,
                        ExpressionType = qca.ExpressionType,
                        OrderDirection = qca.OrderDirection,
                        OrderPosition = qca.OrderPosition,
                    };
                    queryColumns.Add(qc);
                }

                RootSchemaNameAttribute ra = propInfo.GetCustomAttribute<RootSchemaNameAttribute>(true);
                if (ra != null)
                {
                    Type[] types = propInfo.PropertyType.GetInterfaces();
                    var index = Array.FindIndex(types, x => x.Name == "IEnumerable");
                    if (index == -1)//Not a list
                    {

                        string deepProperty = propInfo.PropertyType.FullName;
                        var deepEntity = Activator.CreateInstance(propInfo.PropertyType);
                        GetDeepEntityColumns(deepEntity);

                        Console.WriteLine(deepProperty);

                        QueryColumn qc = new QueryColumn()
                        {
                            Caption = caption,
                            ColumnPath = caption,
                            ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                        };
                        queryColumns.Add(qc);
                    }
                }
            }

            return queryColumns;
        }
#endregion

        #endregion

#region IDisposable

        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Task.Run(async()=> {
                    await LogoutAsync();
                });
                
                CurrentUser = null;
                _instance = null;
                disposed = true;
            }

            // Free any unmanaged objects here.
            //
            Task.Run(async() => {
                await LogoutAsync();
            });

            Auth = null;
            CurrentUser = null;
            _instance = null;
            disposed = true;
        }

        ~Utils()
        {
            Dispose(false);
        }

#endregion
    }
}