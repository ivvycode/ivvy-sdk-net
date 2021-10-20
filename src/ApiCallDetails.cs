using System.Net;
using System.Net.Http.Headers;

namespace Ivvy.API
{
    /// <summary>
    /// ApiCallDetails encapsulates the details of an iVvy api call.
    /// </summary>
    public sealed class ApiCallDetails : ApiCallRequestDetails
    {
        /// <summary>
        /// The json encoded response body.
        /// </summary>
        public readonly string ResponseBody;

        /// <summary>
        /// The http response headers.
        /// </summary>
        public readonly HttpHeaders ResponseHeaders;

        /// <summary>
        /// The http response status code.
        /// </summary>
        public readonly HttpStatusCode ResponseStatusCode;

        public ApiCallDetails(
            string apiNamespace,
            string apiAction,
            HttpHeaders requestHeaders,
            HttpHeaders requestContentHeaders,
            string requestBody,
            HttpStatusCode responseStatusCode,
            HttpHeaders responseHeaders,
            string responseBody)
            : base(
                  apiNamespace,
                  apiAction,
                  requestHeaders,
                  requestContentHeaders,
                  requestBody)
        {
            ResponseStatusCode = responseStatusCode;
            ResponseHeaders = responseHeaders;
            ResponseBody = responseBody;
        }
    }
}