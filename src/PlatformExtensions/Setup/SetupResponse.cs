using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Setup
{
    /// <summary>
    /// This class encapsulates the response an extension must return to
    /// iVvy after verifying a setup request.
    /// </summary>
    public sealed class SetupResponse
    {
        [JsonProperty("success")]
        public bool Success { get; }

        public SetupResponse(bool success)
        {
            Success = success;
        }
    }
}