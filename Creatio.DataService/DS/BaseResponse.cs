using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [DataContract]
    public class BaseResponse
    {
        [DataMember(Name = "responseStatus")]
        public ResponseStatus ResponseStatus { get; set; }
        
        [DataMember(Name = "rowsAffected")]
        public int RowsAffected { get; set; }
        
        [DataMember(Name = "nextPrcElReady")]
        public bool NextPrcElReady { get; set; }

        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "errorInfo")]
        public ErrorInfo ErrorInfo { get; set; }
    }
}
