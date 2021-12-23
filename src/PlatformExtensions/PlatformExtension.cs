using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Ivvy.PlatformExtensions.Installation;
using Ivvy.PlatformExtensions.Installation.Configure;
using Ivvy.PlatformExtensions.Installation.Setup;
using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions
{
    /// <summary>
    /// The primary class used to call the extension endpoints.
    /// </summary>
    public class PlatformExtension : IPlatformExtension
    {
        public string SetupVerifyUrl
        {
            get; set;
        }
        public string SetupConfigureUrl
        {
            get; set;
        }
        public string EventSetupVerifyUrl
        {
            get; set;
        }
        public string EventSetupConfigureUrl
        {
            get; set;
        }
        public string VenueSetupVerifyUrl
        {
            get; set;
        }
        public string VenueSetupConfigureUrl
        {
            get; set;
        }

        /// <summary>
        /// multi-threaded protection for the static httpClient.
        /// </summary>
        private static API.Utils.HttpClientWrapper httpClientWrapper =
            new API.Utils.HttpClientWrapper();

        public static HttpClient SetHttpClient(HttpClient newClient)
        {
            return httpClientWrapper.SetHttpClient(newClient);
        }

        public PlatformExtension()
        {
        }

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to their account.
        /// </summary>
        public async Task<ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey)
        {
            var dataMap = new Dictionary<string, string> {
                { "accountId", accountId },
                { "setupKey", setupKey }
            };
            return await CallAsync<VerifySetupResponse>(SetupVerifyUrl, dataMap);
        }

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured.
        /// </summary>
        public async Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey)
        {
            var dataMap = new Dictionary<string, string> {
                { "accountId", accountId },
                { "setupKey", setupKey }
            };
            return await CallAsync<VerifyConfigureResponse>(SetupConfigureUrl, dataMap);
        }

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to an event in their account.
        /// </summary>
        public async Task<ResultOrError<EventVerifySetupResponse>> EventVerifySetupAsync(
                string accountId, string eventId, string setupKey)
        {
            var dataMap = new Dictionary<string, string> {
                { "accountId", accountId },
                { "eventId", eventId },
                { "setupKey", setupKey }
            };
            return await CallAsync<EventVerifySetupResponse>(EventSetupVerifyUrl, dataMap);
        }

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured within an event.
        /// </summary>
        public async Task<ResultOrError<VerifyConfigureResponse>> EventConfigureAsync(
                string accountId, string eventId, string setupKey)
        {
            var dataMap = new Dictionary<string, string> {
                { "accountId", accountId },
                { "eventId", eventId },
                { "setupKey", setupKey }
            };
            return await CallAsync<VerifyConfigureResponse>(EventSetupConfigureUrl, dataMap);
        }

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to a venue in their account.
        /// </summary>
        public async Task<ResultOrError<VenueVerifySetupResponse>> VenueVerifySetupAsync(
                string accountId, string venueId, string setupKey)
        {
            var dataMap = new Dictionary<string, string> {
                { "accountId", accountId },
                { "venueId", venueId },
                { "setupKey", setupKey }
            };
            return await CallAsync<VenueVerifySetupResponse>(VenueSetupVerifyUrl, dataMap);
        }

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured within a venue.
        /// </summary>
        public async Task<ResultOrError<VerifyConfigureResponse>> VenueConfigureAsync(
                string accountId, string venueId, string setupKey)
        {
            var dataMap = new Dictionary<string, string> {
                { "accountId", accountId },
                { "venueId", venueId },
                { "setupKey", setupKey }
            };
            return await CallAsync<VerifyConfigureResponse>(VenueSetupConfigureUrl, dataMap);
        }

        private async Task<ResultOrError<T>> CallAsync<T>(
            string requestUri, Dictionary<string, string> dataMap)
        {
            HttpResponseMessage httpResponse = null;
            var result = new ResultOrError<T>();
            try
            {
                var httpClient = httpClientWrapper.GetHttpClient();
                httpResponse = await httpClient.PostAsync(requestUri, new FormUrlEncodedContent(dataMap));
                var data = await httpResponse.Content.ReadAsStringAsync();
                JsonConvert.PopulateObject(data, result);
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