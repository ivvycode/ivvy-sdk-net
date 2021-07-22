using System.Net;
using System.Net.Http.Headers;

namespace Ivvy.API
{
    public sealed class ApiCallDetails
    {
        public readonly string ApiNamespace;

        public readonly string ApiAction;

        public readonly string RequestBody;

        public readonly HttpHeaders RequestHeaders;

        public readonly string ResponseBody;

        public readonly HttpHeaders ResponseHeaders;

        public readonly HttpStatusCode ResponseStatusCode;

        public ApiCallDetails(
            string apiNamespace,
            string apiAction,
            HttpHeaders requestHeaders,
            string requestBody,
            HttpStatusCode responseStatusCode,
            HttpHeaders responseHeaders,
            string responseBody)
        {
            ApiNamespace = apiNamespace;
            ApiAction = apiAction;
            RequestHeaders = requestHeaders;
            RequestBody = requestBody;
            ResponseStatusCode = responseStatusCode;
            ResponseHeaders = responseHeaders;
            ResponseBody = responseBody;
        }
    }
}