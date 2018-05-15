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
        public bool Success { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsetupResponse"/> class.
        /// </summary>
        /// <param name="success">if set to <c>true</c> [success].</param>
        public UnsetupResponse(bool success)
        {
            Success = success;
        }
    }
}