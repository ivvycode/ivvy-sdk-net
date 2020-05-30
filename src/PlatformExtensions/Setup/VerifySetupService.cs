using System.Threading.Tasks;

namespace Ivvy.PlatformExtensions.Setup
{
    public class VerifySetupService : IVerifySetupService
    {
        /// <inheritdoc />
        public async Task<VerifySetupResponse> VerifySetupAsync(SetupRequest request)
        {
            var ext = NewPlatformExtension();
            ext.SetupVerifyUrl = request.IvvySetupVerifyUrl;
            ext.SetupConfigureUrl = request.IvvySetupConfigureUrl;
            ext.EventSetupVerifyUrl = request.IvvyEventSetupVerifyUrl;
            ext.EventSetupConfigureUrl = request.IvvyEventSetupConfigureUrl;
            ext.VenueSetupVerifyUrl = request.IvvyVenueSetupVerifyUrl;
            ext.VenueSetupConfigureUrl = request.IvvyVenueSetupConfigureUrl;

            var result =
                await ext.VerifySetupAsync(request.AccountId, request.SetupKey);
            if (result.Success)
            {
                return result.Result;
            }
            return null;
        }

        /// <summary>
        /// Returns a new Extension object.
        /// </summary>
        public virtual IPlatformExtension NewPlatformExtension()
        {
            return new PlatformExtension();
        }
    }
}