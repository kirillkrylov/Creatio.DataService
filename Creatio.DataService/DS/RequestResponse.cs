using System.Net;
namespace Creatio.DataService
{
    public class RequestResponse
    {

        /// <summary>
        /// HttpStatusCode
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// Result String
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Error message is any
        /// </summary>
        public string ErrorMessage { get; set; }

    }
}
