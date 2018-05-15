using Newtonsoft.Json;

namespace Ivvy.Extensions.Setup
{
    /// <summary>
    /// This class encapsulates the response an extension must return to
    /// iVvy after verifying a setup request.
    /// </summary>
    public sealed class SetupResponse
    {
        [JsonProperty("success")]
        public bool Success { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupResponse"/> class.
        /// </summary>
        /// <param name="success">if set to <c>true</c> [success].</param>
        public SetupResponse(bool success)
        {
            Success = success;
        }
    }
}