using System.Threading.Tasks;

namespace Ivvy.PlatformExtensions.Installation.Setup
{
    public class VenueVerifySetupService : IVenueVerifySetupService
    {
        /// <inheritdoc />
        public async Task<VenueVerifySetupResponse> VenueVerifySetupAsync(
            VenueSetupRequest request, string IvvyVenueSetupVerifyUrl)
        {
            var ext = NewPlatformExtension();
            ext.VenueSetupVerifyUrl = IvvyVenueSetupVerifyUrl;

            var result =
                await ext.VenueVerifySetupAsync(request.AccountId, request.VenueId, request.SetupKey);

            return result.Success ? result.Result : null;
        }

        /// <summary>
        /// Returns a new Extension object.
        /// </summary>
        public virtual IPlatformExtension NewPlatformExtension()
            => new PlatformExtension();
    }
}