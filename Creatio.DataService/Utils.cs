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
using Creatio.DataService.Attributes;
using Creatio.DataService.Parameters;

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
        protected CancellationTokenSource cts;
        #endregion

        #region Constructors
        private Utils() { }
        #endregion

        #region Properties
        private CookieContainer Auth { get; set; }
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


        private bool _IsLoginSuccess = false;
        public bool IsLoginSuccess { get { return _IsLoginSuccess; } }


        protected Uri _soketDomain;
        protected Uri SocketDomain 
        {
            get {
                Uri uri = new Uri(domain);
                if (uri.Scheme == "https")
                {
                    _soketDomain = new Uri($"wss://{uri.Host}:{uri.Port}/0/Nui/ViewModule.aspx.ashx");
                }
                else
                {
                    _soketDomain = new Uri($"ws://{uri.Host}:{uri.Port}/0/Nui/ViewModule.aspx.ashx");
                }
                return _soketDomain;
            }
        }


        #endregion

        #region Events
        /// <summary>
        /// Raised when webSocket message is received and read;
        /// </summary>
        public event EventHandler<WebSocketMessageReceivedEventArgs> WebSocketMessageReceived;
        #endregion

        #region Methods : Private

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
            foreach (QueryColumn qc in queryColumns)
            {
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
        private Filters BuildFilterById(Guid id)
        {

            Filters filter = new Filters()
            {
                // Filter type is group.
                FilterType = Enums.FilterType.FilterGroup,
                ComparisonType = Enums.FilterComparisonType.Equal,
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
        private List<Entity> BuildEntity<Entity>(RequestResponse requestResponse) where Entity : BaseEntity, new()
        {
            List<Entity> result = new List<Entity>();
            DataTable dt = ConvertResponseToDataTable(requestResponse.ResultString);
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
        private string GetSubEntityKeyColumn(object subEntity)
        {
            string result = string.Empty;

            PropertyInfo[] props = subEntity.GetType().GetProperties();
            foreach (PropertyInfo subProprty in props)
            {
                if (subProprty.GetCustomAttribute<CPropertyAttribute>()?.IsKey == true)
                {
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
        private List<UpdateQueryColumn> BuildQueryColumnsForUpdate<Entity>(Entity entity) where Entity : BaseEntity, new()
        {
            var SysImageProps = new Dictionary<string, string>();
            foreach (PropertyInfo propInfo in entity.GetType().GetProperties())
            {
                string navProp = propInfo.GetCustomAttribute<CPropertyAttribute>().Navigation?.ToString() ?? "";
                if(!string.IsNullOrEmpty(navProp) && navProp.Contains(":", StringComparison.OrdinalIgnoreCase))
                {
                    if (navProp.Split(':')[0] == "SysImage")
                    {
                        SysImageProps.Add(navProp.Split(':')[1], navProp.Split(':')[0]); //PhotoId, SysImage
                    }
                }
            }
            List<UpdateQueryColumn> queryColumns = new List<UpdateQueryColumn>();
            
            foreach (PropertyInfo propInfo in entity.GetType().GetProperties())
            {
                string caption = propInfo.Name;//PhotoId
                Enums.DataValueType dtv = Enums.DataValueType.Text;
                CPropertyAttribute propertyAttribute = propInfo.GetCustomAttribute<CPropertyAttribute>(true);
                
                if (entity.ChangedColumns.IndexOf(caption) > -1 && propertyAttribute.IsKey == false)
                {
                    if (SysImageProps.ContainsKey(propInfo.Name))
                    {
                        dtv = Enums.DataValueType.ImageLookup;
                        caption = caption.Substring(0, caption.Length - 2);
                    }
                    else
                    {
                        //CPropertyAttribute propertyAttribute = propInfo.GetCustomAttribute<CPropertyAttribute>(true);
                        if (propertyAttribute != null && propertyAttribute.ColumnPath != null && propertyAttribute.IsKey == false)
                        {
                            switch (propInfo.PropertyType.Name)
                            {
                                case nameof(String):
                                    dtv = Enums.DataValueType.Text;
                                    break;

                                case nameof(Int64):
                                case nameof(Int32):
                                case nameof(Int16):
                                    dtv = Enums.DataValueType.Integer;
                                    break;

                                case nameof(Decimal):
                                    dtv = Enums.DataValueType.Float;
                                    break;

                                case nameof(DateTime):
                                    dtv = Enums.DataValueType.DateTime;
                                    break;

                                case nameof(Guid):
                                    dtv = Enums.DataValueType.Guid;
                                    break;

                                case nameof(Boolean):
                                    dtv = Enums.DataValueType.Boolean;
                                    break;

                                default:
                                    dtv = Enums.DataValueType.Text;
                                    break;
                            }
                        }
                        else
                        {
                            dtv = Enums.DataValueType.Guid;
                        }
                    }
                    UpdateQueryColumn updateColumn = new UpdateQueryColumn()
                    {
                        ColumnPath = caption,
                        ExpressionType = Enums.EntitySchemaQueryExpressionType.Parameter,
                        Parameter = new Parameter() { 
                            DataValueType = dtv,
                            Value = propInfo.GetValue(entity)
                        }                        
                    };
                    queryColumns.Add(updateColumn);

                }
            }
            return queryColumns;
        }
        private DeleteQuery BuildDeleteQuery(QueryParameters queryParameters, Guid id)
        {
            DeleteQuery deleteQuery = new DeleteQuery()
            {
                RootSchemaName = queryParameters.RootSchemaName
            };
            deleteQuery.Filters = BuildFilterById(id);
            return deleteQuery;
        }
        private UpdateQuery BuildUpdateQuery<Entity>(QueryParameters queryParameters, Entity entity) where Entity : BaseEntity, new()
        {
            UpdateQuery updateQuery = new UpdateQuery()
            {
                RootSchemaName = queryParameters.RootSchemaName
            };
            List<UpdateQueryColumn> columnsToUpdate = BuildQueryColumnsForUpdate(entity);
            
            Dictionary<string, ColumnExpression> items = new Dictionary<string, ColumnExpression>();
            foreach(UpdateQueryColumn column in columnsToUpdate)
            {
                if (column.Parameter.Value != null) { 
                    ColumnExpression ex = new ColumnExpression()
                    {
                        Parameter = column.Parameter,
                        ExpressionType= column.ExpressionType
                    
                    };
                    items.Add(column.ColumnPath, ex);               
                }
            }
            updateQuery.ColumnValues.Items = items;
            updateQuery.Filters = BuildFilterById(entity.Id);
            return updateQuery;
        }
        private UpdateQuery BuildInsertQuery<Entity>(QueryParameters queryParameters, Entity entity) where Entity : BaseEntity, new()
        {
            UpdateQuery updateQuery = new UpdateQuery()
            {
                RootSchemaName = queryParameters.RootSchemaName
            };
            List<UpdateQueryColumn> columnsToUpdate = BuildQueryColumnsForUpdate(entity);

            Dictionary<string, ColumnExpression> items = new Dictionary<string, ColumnExpression>();
            foreach (UpdateQueryColumn column in columnsToUpdate)
            {
                if (column.Parameter.Value != null)
                {
                    ColumnExpression ex = new ColumnExpression()
                    {
                        Parameter = column.Parameter,
                        ExpressionType = column.ExpressionType

                    };
                    items.Add(column.ColumnPath, ex);
                }
            }
            updateQuery.ColumnValues.Items = items;
            //updateQuery.Filters = BuildFilterById(entity.Id);
            return updateQuery;
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
        public DataTable ConvertResponseToDataTable(string json)
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

        /// <summary>
        /// Sets credentials to use for initial Authentication
        /// </summary>
        /// <param name="UserName">Username to Login with, default Supervisor</param>
        /// <param name="Password">Password to Login with, default Supervisor</param>
        /// <param name="Domain">Application Url i.e. (https://xxxxxxx-studio.creatio.com)</param>
        public static void SetCredentials(string UserName, string Password, string Domain)
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
                
                cts = new CancellationTokenSource();
                Instance.ConectWebSocket(cts.Token);
            }
            return Instance._IsLoginSuccess;
        }
        public async Task<bool> LogoutAsync()
        {
            cts.Cancel();
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
            if (!IsLoginSuccess) await LoginAsync();

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
                            ResultString = PhotoData,
                            ErrorMessage = null
                        };
                        return ir;
                    }
                }
            }
            catch (WebException we)
            {
                Code = ((HttpWebResponse)(we).Response).StatusCode;
                if (Code == HttpStatusCode.Unauthorized)
                {
                    Auth = null;
                    Instance.BpmSessionId = false;
                    Instance.CurrentUser = null;
                    Instance._IsLoginSuccess = false;
                }

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

        public async Task<RequestResponse> GetResponseAsync(string json, ActionEnum method)
        {
            if (!IsLoginSuccess) await LoginAsync();

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
                    if (Instance.BpmSessionId == false)
                    {
                        string val = myHttpWebResponse.Cookies["BPMSESSIONID"].Value;
                        Cookie C = new Cookie("BPMSESSIONID", val);
                        Instance.Auth.Add(new Uri(Instance.domain), C);
                        Instance.BpmSessionId = true;
                    }
                    using (StreamReader MyStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream(), true))
                    {
                        result.HttpStatusCode = Code;
                        result.ResultString = MyStreamReader.ReadToEnd();
                        result.ErrorMessage = null;
                    }
                }
            }
            catch (WebException we)
            {
                Code = ((HttpWebResponse)(we).Response).StatusCode;
                if (Code == HttpStatusCode.Unauthorized) 
                {
                    Auth = null;
                    Instance.BpmSessionId = false;
                    Instance.CurrentUser = null;
                    Instance._IsLoginSuccess = false;
                }

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
        /// Connect to webSocket, every message received will Raise WebSocketMessageReceived Event
        /// </summary>
        protected async void ConectWebSocket(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
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
                try
                {
                    await wss.ConnectAsync(SocketDomain, CancellationToken.None).ConfigureAwait(false);
#if DEBUG       
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Socket Connected ...");
                    Console.ResetColor();
#endif              
                    while (!ct.IsCancellationRequested)
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
                            while (!result.EndOfMessage && !ct.IsCancellationRequested);
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
                    await wss.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
                }
                catch (WebSocketException wse)
                {
                    Console.WriteLine($"ErrorCode:{wse.ErrorCode}:{wse.WebSocketErrorCode}\nMessage:\n{wse.Message}");
                }
                wss.Dispose();
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

            try
            {
                RequestResponse requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT).ConfigureAwait(true);

                if (requestResponse.HttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT);
                }

                if (!string.IsNullOrEmpty(requestResponse.ErrorMessage))
                {
                    return new List<Entity>();
                }

                List<Entity> result = BuildEntity<Entity>(requestResponse);
                return result;

            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public async Task<RequestResponse> DeleteAsyc<Entity>(Entity entity) where Entity : BaseEntity, new()
        {
            QueryParameters queryParameters = BuildQueryParameters<Entity>();
            DeleteQuery deleteQuery = BuildDeleteQuery(queryParameters, entity.Id);
            string deleteQueryJson = JsonConvert.SerializeObject(deleteQuery);
            RequestResponse requestResponse = await GetResponseAsync(deleteQueryJson, ActionEnum.DELETE);
            if (requestResponse.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                requestResponse = await GetResponseAsync(deleteQueryJson, ActionEnum.DELETE);
            }
            return requestResponse;
        }

        public async Task<RequestResponse> UpdateAsync<Entity>(Entity entity, params string[] properties) where Entity : BaseEntity, new()
        {
            QueryParameters queryParameters = BuildQueryParameters<Entity>();
            UpdateQuery updateQuery = BuildUpdateQuery(queryParameters, entity);

            string updateQueryJson = JsonConvert.SerializeObject(updateQuery);
            
            RequestResponse requestResponse = await GetResponseAsync(updateQueryJson, ActionEnum.UPDATE);
            if (requestResponse.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                requestResponse = await GetResponseAsync(updateQueryJson, ActionEnum.UPDATE);
            }
            return requestResponse;
        }

        public async Task<RequestResponse> InsertAsync<Entity>(Entity entity, params string[] properties) where Entity : BaseEntity, new()
        {
            QueryParameters queryParameters = BuildQueryParameters<Entity>();
            UpdateQuery updateQuery = BuildUpdateQuery(queryParameters, entity);

            string updateQueryJson = JsonConvert.SerializeObject(updateQuery);

            RequestResponse requestResponse = await GetResponseAsync(updateQueryJson, ActionEnum.INSERT);
            if (requestResponse.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                requestResponse = await GetResponseAsync(updateQueryJson, ActionEnum.UPDATE);
            }
            return requestResponse;
        }
       
        public async Task<List<Entity>> SelectAssociation<Entity>(string parentId = "", string childColumnName = "") where Entity : BaseEntity, new()
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
            if (requestResponse.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT);
            }

            if (!string.IsNullOrEmpty(requestResponse.ErrorMessage))
            {
                return new List<Entity>();
            }

            List<Entity> result = BuildEntity<Entity>(requestResponse);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="postBytes">file bytes</param>
        /// <param name="mimeType">file mimeType</param>
        /// <param name="fileName">filename</param>
        /// <param name="parentColumnName"></param>
        /// <param name="parentColumnValue"></param>
        /// <param name="entitySchemaName">table where to insert file to</param>
        /// <param name="columnName">column name where to insert datta to</param>
        /// <returns></returns>
        public async Task<RequestResponse> UploadFileAsync(byte[] postBytes, string mimeType, string fileName, string parentColumnName,
            string parentColumnValue, string entitySchemaName, string columnName)
        {

            if (!IsLoginSuccess) await LoginAsync();
            Guid id = Guid.NewGuid();

            bool IsFile = false;
            if (!string.IsNullOrEmpty(parentColumnName) && !string.IsNullOrEmpty(parentColumnName) &&
                !string.IsNullOrEmpty(parentColumnName) && !string.IsNullOrEmpty(parentColumnName))
            {
                IsFile = true;
            }

            string transportUrl = string.Empty;
            if (IsFile)
            {
                transportUrl = Url.TransportUrl(ActionEnum.UPLOADFILE, Instance.domain) + "?fileapi";

                transportUrl = transportUrl + "&totalFileLength=" + postBytes.Length.ToString();
                transportUrl = transportUrl + "&fileId=" + id.ToString();
                transportUrl = transportUrl + "&mimeType=" + mimeType;
                transportUrl = transportUrl + "&fileName=" + fileName;

                transportUrl = transportUrl + "&columnName="+columnName;
                transportUrl = transportUrl + "&parentColumnName="+ parentColumnName;
                transportUrl = transportUrl + "&parentColumnValue="+ parentColumnValue;
                transportUrl = transportUrl + "&entitySchemaName="+entitySchemaName;
            }
            else
            {
                transportUrl = Url.TransportUrl(ActionEnum.UPLOADIMAGE, Instance.domain)+"?fileapi";
                transportUrl = transportUrl + "&totalFileLength=" + postBytes.Length.ToString();
                transportUrl = transportUrl + "&fileId=" + id.ToString();
                transportUrl = transportUrl + "&mimeType=" + mimeType;
                transportUrl = transportUrl + "&fileName=" + fileName;
            }
         

            RequestResponse result = new RequestResponse();
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(transportUrl);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.ContentType = "image/png";
            myHttpWebRequest.CookieContainer = Instance.Auth;
            myHttpWebRequest.Headers.Add("Content-Length", postBytes.Length.ToString());

            string crange = $"bytes 0-{(postBytes.Length - 1)}/{postBytes.Length}";
            myHttpWebRequest.Headers.Add("Content-Range", crange);

            if (!IsFile)
            {
                myHttpWebRequest.Headers.Add("Content-Disposition", $"attachment; filename={fileName}");
            }

            Uri siteUri = new Uri(transportUrl);
            foreach (Cookie cookie in Instance.Auth.GetCookies(siteUri))
            {
                if (cookie.Name == "BPMCSRF" || cookie.Name == "BPMSESSIONID")
                {
                    myHttpWebRequest.Headers.Add(cookie.Name, cookie.Value);
                }
            }

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
                    
                    HttpStatusCode Code = myHttpWebResponse.StatusCode;
                    if (Instance.BpmSessionId == false)
                    {
                        string val = myHttpWebResponse.Cookies["BPMSESSIONID"].Value;
                        Cookie C = new Cookie("BPMSESSIONID", val);
                        Instance.Auth.Add(new Uri(Instance.domain), C);
                        Instance.BpmSessionId = true;
                    }
                    using (StreamReader MyStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream(), true))
                    {
                        result.HttpStatusCode = Code;
                        result.ResultString = MyStreamReader.ReadToEnd();
                        result.Result.Id = id;
                        result.ErrorMessage = null;
                    }
                }
            }
            catch (WebException we)
            {
                HttpStatusCode Code = ((HttpWebResponse)(we).Response).StatusCode;
                if (Code == HttpStatusCode.Unauthorized)
                {
                    Auth = null;
                    Instance.BpmSessionId = false;
                    Instance.CurrentUser = null;
                    Instance._IsLoginSuccess = false;
                }

                using (StreamReader MyStreamReader = new StreamReader(((HttpWebResponse)(we).Response).GetResponseStream(), true))
                {
                    result.HttpStatusCode = Code;
                    result.Result = null;
                    result.ErrorMessage = MyStreamReader.ReadToEnd();
                }
            }
            return result;
        }

        /* Unused SelectList
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

            SelectQuery selectQuery = BuildSelectRequest(queryParameters, QueryColumns);
            if (parentId != Guid.Empty)
            {
                Filters filterById = BuildFilterByParent(parentId, childColumnName);
                selectQuery.Filters = filterById;
            }
            string selectQueryJson = JsonConvert.SerializeObject(selectQuery);
            RequestResponse requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT);
            if (requestResponse.HttpStatusCode == HttpStatusCode.Unauthorized)
            {
                requestResponse = await GetResponseAsync(selectQueryJson, ActionEnum.SELECT);
            }
            List<Entity> result = BuildEntity<Entity>(requestResponse);
            return result;
        }
        */

        

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
                Task.Run(async () =>
                {
                    await LogoutAsync();
                });

                CurrentUser = null;
                _instance = null;
                disposed = true;
            }

            // Free any unmanaged objects here.
            //
            Task.Run(async () =>
            {
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
    }
}
 