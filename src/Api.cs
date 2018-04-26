using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Ivvy.Json.Converters;

namespace Ivvy
{
    /// <summary>
    /// The primary class used to call methods of the iVvy api.
    /// </summary>
    public partial class Api : IApi
    {
        /// <summary>
        /// The api version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The base url of the api.
        /// </summary>
        public string BaseUrl { get; private set; }

        /// <summary>
        /// The key required to call api methods.
        /// </summary>
        private string ApiKey { get; set; }

        /// <summary>
        /// The secret required to call api methods.
        /// </summary>
        private string ApiSecret { get; set; }

        /// <summary>
        /// Http client used to call the iVVy api.
        /// </summary>
        private static HttpClient httpClient = new HttpClient();

        ///// <summary>
        ///// Constructs a new api object with default values to call methods
        ///// on the production iVvy api.
        ///// </summary>
        //public Api(string apiKey, string apiSecret) : this(apiKey, apiSecret, "1.0", "https://api.ivvy.com")
        //{
        //}

        ///// <summary>
        ///// Constructs a new api object with specific values to call methods
        ///// on a specific iVvy api environment.
        ///// </summary>
        //public Api(string apiKey, string apiSecret, string apiVersion, string baseUrl)
        //{
        //    if (apiVersion != "1.0") {
        //        throw new ArgumentException("apiVersion is not a valid version number");
        //    }
        //    ApiKey = apiKey;
        //    ApiSecret = apiSecret;
        //    ApiVersion = apiVersion;
        //    BaseUrl = baseUrl.TrimEnd(new char[] { '/', ' ' });
        //}

        public void InitializeApi(string apiKey, string apiSecret, string apiVersion, string baseUrl)
        {
            if (apiVersion != "1.0")
            {
                throw new ArgumentException("apiVersion is not a valid version number");
            }
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            ApiVersion = apiVersion;
            BaseUrl = baseUrl.TrimEnd('/', ' ');
        }

        /// <summary>
        /// Calls a method of the iVVy api. Encapsulates the header and
        /// signing requirements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiNamespace">The API namespace.</param>
        /// <param name="action">The action.</param>
        /// <param name="requestData">The request data.</param>
        /// <returns></returns>
        protected async Task<ResultOrError<T>> CallAsync<T>(
            string apiNamespace, string action, object requestData) where T : new()
        {
            string postData = "";
            if (requestData != null) {
                postData = JsonConvert.SerializeObject(
                    requestData,
                    Formatting.None,
                    new JsonSerializerSettings {
                        NullValueHandling = NullValueHandling.Ignore
                    }
                );
            }
            string method = "POST";
            string contentType = "application/json; charset=utf-8";
            string contentMd5 = Utils.GetMd5Hash(postData);
            string date = "";
            string requestUri = "/api/" + ApiVersion + "/" + apiNamespace + "?action=" + action;
            string ivvyDate = DateTime.Now.ToUniversalTime().ToString(Utils.DateTimeFormat);
            string headersToSign = "IVVYDate=" + ivvyDate;
            string initialStringToSign = method + contentMd5 + contentType + date + requestUri + ApiVersion + headersToSign;
            string stringToSign = initialStringToSign.ToLower();
            string signature = Utils.SignString(stringToSign, ApiSecret);

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, BaseUrl + requestUri);
            message.Headers.Clear();
            message.Content = new StringContent(postData, Encoding.UTF8, "application/json");
            message.Content.Headers.Add("Content-MD5", contentMd5);
            message.Content.Headers.Add("IVVY-Date", ivvyDate);
            message.Content.Headers.Add("X-Api-Authorization", "IWS " + ApiKey + ":" + signature);

            HttpResponseMessage httpResponse = await httpClient.SendAsync(message);
            string data = await httpResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResultOrError<T>>(data, new ResponseConverter<T>());
        }
    }
}