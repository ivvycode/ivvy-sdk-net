using System.Threading.Tasks;

namespace Ivvy.PlatformExtensions.Installation.Setup
{
    public class VenueVerifySetupService : IVenueVerifySetupService
    {
        /// <inheritdoc />
        public async Task<VenueVerifySetupResponse> VerifySetupAsync(
            VenueSetupRequest request,
            string ivvyVenueSetupVerifyUrl)
        {
            var ext = NewPlatformExtension();
            ext.VenueSetupVerifyUrl = ivvyVenueSetupVerifyUrl;

            var result = await ext.VenueVerifySetupAsync(
                request.AccountId,
                request.VenueId,
                request.SetupKey
            );

            return result.Success ? result.Result : null;
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