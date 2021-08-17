using System.Net;
using System.Net.Http.Headers;

namespace Ivvy.API
{
    /// <summary>
    /// ApiCallDetails encapsulates the details of an iVvy api call.
    /// </summary>
    public sealed class ApiCallDetails
    {
        /// <summary>
        /// The namespace of the api request.
        /// </summary>
        public readonly string ApiNamespace;

        /// <summary>
        /// The action of the api request.
        /// </summary>
        public readonly string ApiAction;

        /// <summary>
        /// The json encoded request body.
        /// </summary>
        public readonly string RequestBody;

        /// <summary>
        /// The http request headers.
        /// </summary>
        public readonly HttpHeaders RequestHeaders;

        /// <summary>
        /// The http request content headers.
        /// </summary>
        public readonly HttpHeaders RequestContentHeaders;

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
        {
            ApiNamespace = apiNamespace;
            ApiAction = apiAction;
            RequestHeaders = requestHeaders;
            RequestContentHeaders = requestContentHeaders;
            RequestBody = requestBody;
            ResponseStatusCode = responseStatusCode;
            ResponseHeaders = responseHeaders;
            ResponseBody = responseBody;
        }
    }
}