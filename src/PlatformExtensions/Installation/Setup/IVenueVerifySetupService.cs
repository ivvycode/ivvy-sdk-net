using System.Threading.Tasks;

namespace Ivvy.PlatformExtensions.Installation.Setup
{
    /// <summary>
    /// Verifies a new venue extension setup request.
    /// </summary>
    public interface IVenueVerifySetupService
    {
        /// <summary>
        /// Verifies an iVvy venue extension setup request.
        /// </summary>
        Task<VenueVerifySetupResponse> VerifySetupAsync(
            VenueSetupRequest request,
            string ivvyVenueSetupVerifyUrl
        );
    }
}