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
        Task<Ivvy.Extensions.ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey);

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured.
        /// </summary>
        Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey);

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to an event in their account.
        /// </summary>
        Task<ResultOrError<EventVerifySetupResponse>> EventVerifySetupAsync(string accountId, string eventId, string setupKey);

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured within an event.
        /// </summary>
        Task<ResultOrError<VerifyConfigureResponse>> EventConfigureAsync(string accountId, string eventId, string setupKey);

        /// <summary>
        /// Verifies an iVvy client's request to add the extension to a venue in their account.
        /// </summary>
        Task<ResultOrError<VenueVerifySetupResponse>> VenueVerifySetupAsync(string accountId, string venueId, string setupKey);

        /// <summary>
        /// This method is used by an extension to inform iVvy that it has been configured within a venue.
        /// </summary>
        Task<ResultOrError<VerifyConfigureResponse>> VenueConfigureAsync(string accountId, string venueId, string setupKey);
    }
}
