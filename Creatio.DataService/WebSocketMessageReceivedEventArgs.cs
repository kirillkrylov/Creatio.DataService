using Newtonsoft.Json;
using System;

namespace Creatio.DataService
{
    public class WebSocketMessageReceivedEventArgs
    {
        [JsonProperty("Id")]
        public Guid MessageId { get; set; }

        [JsonProperty("Header")]
        public Header MessageHeader { get; set; }

        [JsonProperty("Body")]
        public string MessageBody { get; set; }
    }


    public class DisconnectedEventArgs
    {
        public int ErrorCode { get; set; }

        public string Message { get; set; }
    }

    public class Header
    {
        [JsonProperty("Sender")]
        public string Sender { get; set; }

        [JsonProperty("BodyTypeName")]
        public string BodyTypeName { get; set; }
    }


}
