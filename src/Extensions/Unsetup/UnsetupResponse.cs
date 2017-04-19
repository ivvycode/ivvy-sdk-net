using Newtonsoft.Json;

namespace Ivvy.Extensions.Unsetup
{
    /// <summary>
    /// This class encapsulates the response an extension must return to
    /// iVvy after receiving an unsetup request.
    /// </summary>
    public sealed class UnsetupResponse
    {
        [JsonProperty("success")]
        public bool Success { get; private set; }

        public UnsetupResponse(bool success)
        {
            this.Success = success;
        }
    }
}