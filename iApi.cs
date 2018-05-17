namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Initializes the API.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiSecret">The API secret.</param>
        /// <param name="apiVersion">The API version.</param>
        /// <param name="baseUrl">The base URL.</param>
        void InitializeApi(string apiKey, string apiSecret, string apiVersion, string baseUrl);
    }
}
