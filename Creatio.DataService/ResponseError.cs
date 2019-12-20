using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [DataContract]
    public class ResponseError
    {
        public ResponseError() { }

        [DataMember(Order = 1)]
        public string ErrorCode { get; set; }
        [DataMember(Order = 2)]
        public string FieldName { get; set; }
        [DataMember(Order = 3)]
        public string Message { get; set; }
    }
}
