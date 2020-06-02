using Ivvy.PlatformExtensions.Installation;
using Ivvy.PlatformExtensions.Installation.Configure;
using Ivvy.PlatformExtensions.Installation.Setup;
using System.Threading.Tasks;

namespace Ivvy.PlatformExtensions
{
    public interface IPlatformExtension
    {
        string SetupVerifyUrl
        {
            get; set;
        }
        string SetupConfigureUrl
        {
            get; set;
        }
        string EventSetupVerifyUrl
        {
            get; set;
        }
        string EventSetupConfigureUrl
        {
            get; set;
        }
        string VenueSetupVerifyUrl
        {
            get; set;
        }
        string VenueSetupConfigureUrl
        {
            get; set;
        }

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to their account.
        /// </summary>
        /// <param name="accountId">The account identifier.</param>
        /// <param name="setupKey">The setup key.</param>
        /// <returns></returns>
        Task<ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey);

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