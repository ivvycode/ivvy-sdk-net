namespace Ivvy.API
{
    public partial interface IApiClient
    {
        /// <summary>
        /// The api version.
        /// </summary>
        string ApiVersion
        {
            get; set;
        }

        /// <summary>
        /// The base url of the api.
        /// </summary>
        string BaseUrl
        {
            get; set;
        }

        /// <summary>
        /// The key required to call api methods.
        /// </summary>
        string ApiKey
        {
            get; set;
        }

        /// <summary>
        /// The secret required to call api methods.
        /// </summary>
        string ApiSecret
        {
            get; set;
        }
    }
}