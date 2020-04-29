using Newtonsoft.Json;
using System;
using System.Net;
namespace Creatio.DataService
{
    public class RequestResponse
    {
        /// <summary>
        /// HttpStatusCode
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }
        protected string _ResultString;
        /// <summary>
        /// Result String
        /// </summary>
        public string ResultString { 
            get { return _ResultString; }
            set 
            {
                _ResultString = value;
                try
                {
                    if(!string.IsNullOrEmpty(_ResultString))
                    Result = JsonConvert.DeserializeObject<ResponseResult>(_ResultString);
                }
                catch (JsonException ex)
                {
                    Result = new ResponseResult();
                }
            }
        }

        public ResponseResult Result { get; set; }

        /// <summary>
        /// Error message is any
        /// </summary>
        protected string _ErrorMessage;
        public string ErrorMessage {
            get { return _ErrorMessage; }
            set 
            {
                _ErrorMessage = value;
                try
                {
                    if(!string.IsNullOrEmpty(_ErrorMessage))
                        Result = JsonConvert.DeserializeObject<ResponseResult>(_ErrorMessage);
                }
                catch (JsonException ex)
                {
                    Result = new ResponseResult();
                }
            }
        }
    }

    public class ResponseResult
    {
        [JsonProperty("rowsAffected")]
        public int RowsAffected { get; set; } = 0;

        [JsonProperty("nextPrcElReady")]
        public bool NextPrcElReady { get; set; } = false;

        [JsonProperty("success")]
        public bool Success { get; set; } = false;

        [JsonProperty("id")]
        public Guid Id { get; set; }

    }
}
