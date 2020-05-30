using System.Threading.Tasks;

namespace Ivvy.PlatformExtensions.Setup
{
    /// <summary>
    /// Verifies a new account extension setup request.
    /// </summary>
    public interface IVerifySetupService
    {
        /// <summary>
        /// Verifies an iVvy account extension setup request.
        /// </summary>
        Task<VerifySetupResponse> VerifySetupAsync(SetupRequest request);
    }
}