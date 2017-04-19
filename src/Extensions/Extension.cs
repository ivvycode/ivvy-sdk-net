using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Ivvy.Extensions.Setup;
using Ivvy.Extensions.Configure;

namespace Ivvy.Extensions
{
    /// <summary>
    /// The primary class used to call the extension endpoints.
    /// </summary>
    public class Extension
    {
        public string BaseUrl { get; private set; }

        private static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Constructs a new object with default values to call
        /// production extension endpoints.
        /// </summary>
        public Extension() : this("https://www.ivvy.com")
        {
        }

        /// <summary>
        /// Constructs a new object with specific values to call
        /// extension endpoints on a specific environment.
        /// </summary>
        public Extension(string baseUrl)
        {
            BaseUrl = baseUrl.TrimEnd(new char[] { '/', ' ' });
        }

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to their account.
        /// </summary>
        public async Task<ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey)
        {
            return await this.CallAsync<VerifySetupResponse>("/extension/verify", accountId, setupKey);            
        }

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured.
        /// </summary>
        public async Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey)
        {
            return await this.CallAsync<VerifyConfigureResponse>("/extension/configure", accountId, setupKey);
        }

        private async Task<ResultOrError<T>> CallAsync<T>(
            string requestUri, string accountId, string setupKey)
        {
            var httpContent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("accountId", accountId),
                new KeyValuePair<string, string>("setupKey", setupKey)
            });
            HttpResponseMessage httpResponse = await httpClient.PostAsync(
                BaseUrl + requestUri, httpContent
            );
            string data = await httpResponse.Content.ReadAsStringAsync();
            var result = new ResultOrError<T>();
            JsonConvert.PopulateObject(data, result);
            return result;
        }
    }
}