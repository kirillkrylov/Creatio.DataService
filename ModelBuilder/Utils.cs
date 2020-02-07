using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ModelBuilder
{
    public class Utils
    {
        private static volatile Utils _instance;
        private static readonly object _syncLock = new object();
        private bool BpmSessionId = false;
        public IConnectionString ConnectionString;
        
        public CookieContainer AuthCookieContainer { get; set; }
        
        private bool _IsLoginSuccess = false;
        public bool IsLoginSuccess { get { return _IsLoginSuccess; } }
        
        private Utils() { }
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

        
        /// <summary>
        /// Logs in with username and passowrd to the application and stores cookies in the container to use in the following requests
        /// <see cref="https://academy.creatio.com/documents/technic-sdk/7-15/authservicesvc-authentication-service"/>
        /// </summary>
        /// <param name="userName">Username to login</param>
        /// <param name="password">Password to login</param>
        /// <param name="domain">example https://work.creatio.com</param>
        /// <returns>Cookies to use in the following requests</returns>
        private CookieContainer AuthRequest()
        {
            {
                if (ConnectionString.Uri.EndsWith("/", StringComparison.Ordinal))
                    ConnectionString.Uri = ConnectionString.Uri.Remove(ConnectionString.Uri.Length - 1, 1);

                CookieContainer AuthCookie = new CookieContainer();
                string authServiceUri = ConnectionString.Uri + @"/ServiceModel/AuthService.svc/Login";

                HttpWebRequest authRequest = (HttpWebRequest)WebRequest.Create(authServiceUri);
                authRequest.Method = "POST";
                authRequest.ContentType = "application/json";
                authRequest.CookieContainer = AuthCookie;
                using (var requestStream = authRequest.GetRequestStream())
                {
                    using (StreamWriter writer = new StreamWriter(requestStream))
                    {
                        writer.Write(@"{
                    ""UserName"":""" + ConnectionString.Username + @""",
                    ""UserPassword"":""" + ConnectionString.Password + @"""
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
                            string loginFailedMessage = jsonResponse.SelectToken("Message").Value<string>();                            
                            throw new ModelBuilderException(loginFailedMessage);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sets credentials to use for initial Authentication
        /// </summary>
        /// <param name="UserName">Username to Login with</param>
        /// <param name="Password">Password to Login with</param>
        /// <param name="Domain">Application Url i.e. (https://0123456-studio.creatio.com)</param>
        

        /// <summary>
        /// Logs in and requests Current User info
        /// </summary>
        /// <returns>Authentication result</returns>
        public void Login()
        {
            AuthCookieContainer = AuthRequest();

        }

        public async Task<bool> LogoutAsync()
        {
            var logout = await GetResponseAsync("{}", ActionEnum.LOGOUT).ConfigureAwait(false);
            if (logout.HttpStatusCode == HttpStatusCode.OK)
            {
                AuthCookieContainer = null;
                Instance.BpmSessionId = false;
                Instance._IsLoginSuccess = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<RequestResponse> GetResponseAsync(string json, ActionEnum method)
        {
            string transportUrl = Url.TransportUrl(method, ConnectionString.Uri);
            HttpStatusCode Code;
            RequestResponse result = new RequestResponse();
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(transportUrl);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.ContentType = "application/json";
            myHttpWebRequest.CookieContainer = Instance.AuthCookieContainer;

            Uri siteUri = new Uri(transportUrl);
            foreach (Cookie cookie in Instance.AuthCookieContainer.GetCookies(siteUri))
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
                        Instance.AuthCookieContainer.Add(new Uri(Instance.ConnectionString.Uri), C);
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


        public async Task<RequestResponse> GetMetadata() {

            string transportUrl = Url.TransportUrl(ActionEnum.METADATA, ConnectionString.Uri);
            HttpStatusCode Code;
            RequestResponse result = new RequestResponse();
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(transportUrl));
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "application/json";
            myHttpWebRequest.Timeout = 100000;
            myHttpWebRequest.CookieContainer = Instance.AuthCookieContainer;


            Uri siteUri = new Uri(transportUrl);
            foreach (Cookie cookie in Instance.AuthCookieContainer.GetCookies(siteUri))
            {
                if (cookie?.Name == "BPMCSRF" || cookie?.Name == "BPMSESSIONID")
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
                        Instance.AuthCookieContainer.Add(new Uri(Instance.ConnectionString.Uri), C);
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
    }
}