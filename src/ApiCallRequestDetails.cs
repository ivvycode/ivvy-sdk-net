using System.Net;
using System.Net.Http.Headers;

namespace Ivvy.API
{
    /// <summary>
    /// ApiCallRequestDetails encapsulates the request details of an iVvy api call.
    /// </summary>
    public class ApiCallRequestDetails
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

        public ApiCallRequestDetails(
            string apiNamespace,
            string apiAction,
            HttpHeaders requestHeaders,
            HttpHeaders requestContentHeaders,
            string requestBody)
        {
            ApiNamespace = apiNamespace;
            ApiAction = apiAction;
            RequestHeaders = requestHeaders;
            RequestContentHeaders = requestContentHeaders;
            RequestBody = requestBody;
        }
    }
}