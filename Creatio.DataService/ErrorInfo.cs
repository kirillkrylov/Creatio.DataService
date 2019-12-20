using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [DataContract]
    public class ErrorInfo
    {
        public ErrorInfo() { }
        [DataMember(Name = "errorCode")]
        public string ErrorCode { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "stackTrace")]
        public string StackTrace { get; set; }
    }
}
