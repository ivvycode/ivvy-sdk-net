using Ivvy.Extensions.Configure;
using Ivvy.Extensions.Setup;
using System.Threading.Tasks;

namespace Ivvy.Extensions
{
    public interface IExtension
    {
        /// <summary>
        /// Initializes the extension object with values required to call the extension endpoints.
        /// </summary>
        /// <param name="setupVerifyUrl">The setup verify URL.</param>
        /// <param name="setupConfigureUrl">The setup configure URL.</param>
        /// <param name="eventSetupVerifyUrl">The event setup verify URL.</param>
        /// <param name="eventSetupConfigureUrl">The event setup configure URL.</param>
        /// <param name="venueSetupVerifyUrl">The venue setup verify URL.</param>
        /// <param name="venueSetupConfigureUrl">The venue setup configure URL.</param>
        void InitializeExtension(
            string setupVerifyUrl,
            string setupConfigureUrl,
            string eventSetupVerifyUrl,
            string eventSetupConfigureUrl,
            string venueSetupVerifyUrl,
            string venueSetupConfigureUrl);

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to their account.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<Ivvy.Extensions.ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey);

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey);

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to an event in their account.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<EventVerifySetupResponse>> EventVerifySetupAsync(string accountId, string eventId, string setupKey);

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured within an event.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifyConfigureResponse>> EventConfigureAsync(string accountId, string eventId, string setupKey);

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to a venue in their account.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VenueVerifySetupResponse>> VenueVerifySetupAsync(string accountId, string venueId, string setupKey);

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured within a venue.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifyConfigureResponse>> VenueConfigureAsync(string accountId, string venueId, string setupKey);
    }
}
