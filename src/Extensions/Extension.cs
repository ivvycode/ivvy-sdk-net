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
        public string SetupVerifyUrl { get; private set; }
        public string SetupConfigureUrl { get; private set; }
        public string EventSetupVerifyUrl { get; private set; }
        public string EventSetupConfigureUrl { get; private set; }

        private static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Constructs a new object with specific values to call
        /// extension endpoints on a specific environment.
        /// </summary>
        public Extension(
            string setupVerifyUrl,
            string setupConfigureUrl,
            string eventSetupVerifyUrl,
            string eventSetupConfigureUrl)
        {
            SetupVerifyUrl = setupVerifyUrl.TrimEnd(new char[] { '/', ' ' });
            SetupConfigureUrl = setupConfigureUrl.TrimEnd(new char[] { '/', ' ' });
            EventSetupVerifyUrl = eventSetupVerifyUrl.TrimEnd(new char[] { '/', ' ' });
            EventSetupConfigureUrl = eventSetupConfigureUrl.TrimEnd(new char[] { '/', ' ' });
        }

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to their account.
        /// </summary>
        public async Task<ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey)
        {
            return await this.CallAsync<VerifySetupResponse>(SetupVerifyUrl, accountId, setupKey);            
        }

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured.
        /// </summary>
        public async Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey)
        {
            return await this.CallAsync<VerifyConfigureResponse>(SetupConfigureUrl, accountId, setupKey);
        }

        private async Task<ResultOrError<T>> CallAsync<T>(
            string requestUri, string accountId, string setupKey)
        {
            var httpContent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("accountId", accountId),
                new KeyValuePair<string, string>("setupKey", setupKey)
            });
            HttpResponseMessage httpResponse = await httpClient.PostAsync(
                requestUri, httpContent
            );
            string data = await httpResponse.Content.ReadAsStringAsync();
            var result = new ResultOrError<T>();
            JsonConvert.PopulateObject(data, result);
            return result;
        }
    }
}