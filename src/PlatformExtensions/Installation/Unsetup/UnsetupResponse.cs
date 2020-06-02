using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Installation.Unsetup
{
    /// <summary>
    /// This class encapsulates the response an extension must return to
    /// iVvy after receiving an unsetup request.
    /// </summary>
    public sealed class UnsetupResponse
    {
        [JsonProperty("success")]
        public bool Success
        {
            get;
        }

        public UnsetupResponse(bool success)
        {
            Success = success;
        }
    }
}