namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Initializes the api object with values required to execute api actions.
        /// </summary>
        /// <param name="apiKey">The key required to call api methods.</param>
        /// <param name="apiSecret">The secret required to call api methods.</param>
        /// <param name="apiVersion">The api version.</param>
        /// <param name="baseUrl">The base url of the api.</param>
        void InitializeApi(string apiKey, string apiSecret, string apiVersion, string baseUrl);
    }
}
