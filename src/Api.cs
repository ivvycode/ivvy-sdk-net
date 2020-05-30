using Ivvy.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;

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
        public string ApiVersion
        {
            get; set;
        }

        /// <summary>
        /// The base url of the api.
        /// </summary>
        public string BaseUrl
        {
            get; set;
        }

        /// <summary>
        /// The key required to call api methods.
        /// </summary>
        public string ApiKey
        {
            get; set;
        }

        /// <summary>
        /// The secret required to call api methods.
        /// </summary>
        public string ApiSecret
        {
            get; set;
        }

        /// <summary>
        /// Http client used to call the iVvy api.
        /// </summary>
        private static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// This error code is used to represent an error related to this library implementation.
        /// </summary>
        private static string LibErrorCode = "000";

        public Api()
        {
            ApiVersion = "1.0";
        }

        /// <summary>
        /// Calls a method of the iVvy api. Encapsulates the header and
        /// signing requirements.
        /// </summary>
        protected async Task<ResultOrError<T>> CallAsync<T>(
            string apiNamespace, string action, object requestData) where T : new()
        {
            if (ApiVersion != "1.0")
            {
                throw new ArgumentException("ApiVersion is not a valid version number");
            }
            string postData = "";
            if (requestData != null)
            {
                postData = JsonConvert.SerializeObject(
                    requestData,
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Converters = new List<JsonConverter>() { new IsoDateTimeConverter() { DateTimeFormat = Utils.DateTimeFormat } }
                    }
                );
            }
            string method = "POST";
            string contentType = "application/json; charset=utf-8";
            string contentMD5 = Utils.GetMD5Hash(postData);
            string date = "";
            string requestUri = "/api/" + ApiVersion + "/" + apiNamespace + "?action=" + action;
            string ivvyDate = DateTime.Now.ToUniversalTime().ToString(Utils.DateTimeFormat);
            string headersToSign = "IVVYDate=" + ivvyDate;
            string initialStringToSign = method + contentMD5 + contentType + date + requestUri + ApiVersion + headersToSign;
            string stringToSign = initialStringToSign.ToLower();
            string signature = Utils.SignString(stringToSign, ApiSecret);

            var message = new HttpRequestMessage(HttpMethod.Post, BaseUrl + requestUri);
            message.Headers.Clear();
            message.Content = new StringContent(postData, Encoding.UTF8, "application/json");
            message.Content.Headers.Add("Content-MD5", contentMD5);
            message.Content.Headers.Add("IVVY-Date", ivvyDate);
            message.Content.Headers.Add("X-Api-Authorization", "IWS " + ApiKey + ":" + signature);

            HttpResponseMessage httpResponse = null;
            ResultOrError<T> result = null;
            try
            {
                httpResponse = await httpClient.SendAsync(message);
                string data = await httpResponse.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ResultOrError<T>>(data, new ResponseConverter<T>());
                if (result == null)
                {
                    result = new ResultOrError<T>()
                    {
                        ErrorCode = LibErrorCode,
                        ErrorCodeSpecific = "CallAsync",
                        ErrorMessage = "Received invalid response.",
                    };
                }
            }
            catch (Exception ex)
            {
                result = new ResultOrError<T>()
                {
                    ErrorCode = LibErrorCode,
                    ErrorCodeSpecific = "CallAsync",
                    ErrorMessage = ex.Message,
                };
            }
            finally
            {
                if (httpResponse != null)
                {
                    httpResponse.Dispose();
                }
            }
            return result;
        }
    }
}