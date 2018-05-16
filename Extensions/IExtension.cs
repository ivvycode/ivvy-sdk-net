using Ivvy.Extensions.Configure;
using Ivvy.Extensions.Setup;
using System.Threading.Tasks;

namespace Ivvy.Extensions
{
    public interface IExtension
    {
        /// <summary>
        /// Initializes the extension.
        /// </summary>
        /// <param name="setupVerifyUrl">The setup verify URL.</param>
        /// <param name="setupConfigureUrl">The setup configure URL.</param>
        /// <param name="eventSetupVerifyUrl">The event setup verify URL.</param>
        /// <param name="eventSetupConfigureUrl">The event setup configure URL.</param>
        /// <param name="venueSetupVerifyUrl">The venue setup verify URL.</param>
        /// <param name="venueSetupConfiguUrl">The venue setup configu URL.</param>
        void InitializeExtension(string setupVerifyUrl, string setupConfigureUrl, string eventSetupVerifyUrl
            , string eventSetupConfigureUrl, string venueSetupVerifyUrl, string venueSetupConfiguUrl);

        /// <summary>
        /// Verifies the setup asynchronous.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<Ivvy.Extensions.ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey);

        /// <summary>
        /// Configures the asynchronous.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey);

        /// <summary>
        /// Events the verify setup asynchronous.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<EventVerifySetupResponse>> EventVerifySetupAsync(string accountId, string eventId, string setupKey);

        /// <summary>
        /// Events the configure asynchronous.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifyConfigureResponse>> EventConfigureAsync(string accountId, string eventId, string setupKey);

        /// <summary>
        /// Venues the verify setup asynchronous.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VenueVerifySetupResponse>> VenueVerifySetupAsync(string accountId, string venueId, string setupKey);

        /// <summary>
        /// Venues the configure asynchronous.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifyConfigureResponse>> VenueConfigureAsync(string accountId, string venueId, string setupKey);
    }
}
