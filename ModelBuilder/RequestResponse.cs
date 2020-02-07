using System.Net;
namespace ModelBuilder
{
    public class RequestResponse
    {
        /// <summary>
        /// HttpStatusCode
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Result { get; set; }
        public string ErrorMessage { get; set; }

    }
}
