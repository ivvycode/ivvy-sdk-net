using Ivvy.Extensions.Configure;
using Ivvy.Extensions.Setup;
using System.Threading.Tasks;

namespace Ivvy.Extensions
{
    public interface IExtension
    {
        void InitializeExtension(string setupVerifyUrl, string setupConfigureUrl, string eventSetupVerifyUrl
            , string eventSetupConfigureUrl, string venueSetupVerifyUrl, string venueSetupConfiguUrl);

        Task<Ivvy.Extensions.ResultOrError<VerifySetupResponse>> VerifySetupAsync(string accountId, string setupKey);

        Task<ResultOrError<VerifyConfigureResponse>> ConfigureAsync(string accountId, string setupKey);

        Task<ResultOrError<EventVerifySetupResponse>> EventVerifySetupAsync(string accountId, string eventId, string setupKey);

        Task<ResultOrError<VerifyConfigureResponse>> EventConfigureAsync(string accountId, string eventId, string setupKey);

        Task<ResultOrError<VenueVerifySetupResponse>> VenueVerifySetupAsync(string accountId, string venueId, string setupKey);

        Task<ResultOrError<VerifyConfigureResponse>> VenueConfigureAsync(string accountId, string venueId, string setupKey);
    }
}
