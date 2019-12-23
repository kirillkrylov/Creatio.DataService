using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [DataContract]
    public class ResponseStatus
    {
        //
        // Summary:
        //     Initializes a new instance of the ServiceStack.ServiceInterface.ServiceModel.ResponseStatus
        //     class. A response status without an errorcode == success
        public ResponseStatus() { }
        //
        // Summary:
        //     Initializes a new instance of the ServiceStack.ServiceInterface.ServiceModel.ResponseStatus
        //     class. A response status with an errorcode == failure
        public ResponseStatus(string errorCode) { }
        //
        // Summary:
        //     Initializes a new instance of the ServiceStack.ServiceInterface.ServiceModel.ResponseStatus
        //     class. A response status with an errorcode == failure
        public ResponseStatus(string errorCode, string message) { }
        //
        // Summary:
        //     Holds the custom ErrorCode enum if provided in ValidationException otherwise
        //     will hold the name of the Exception type, e.g. typeof(Exception).Name A value
        //     of non-null means the service encountered an error while processing the request.
        
        [DataMember(Order = 1)]
        public string ErrorCode { get; set; }
       
        //
        // Summary:
        //     A human friendly error message
        [DataMember(Order = 2)]
        public string Message { get; set; }
        
        [DataMember(Order = 3)]
        public string StackTrace { get; set; }
        
        //
        // Summary:
        //     For multiple detailed validation errors. Can hold a specific error message for
        //     each named field.
        [DataMember(Order = 4)]
        public List<ResponseError> Errors { get; set; }
    }
}
