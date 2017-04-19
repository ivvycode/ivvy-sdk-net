using Newtonsoft.Json;

namespace Ivvy.Extensions.Configure
{
    /// <summary>
    /// This class encapsulates the details required by iVvy when
    /// an extension calls the configure endpoint.
    /// </summary>
    public sealed class ConfigureRequest
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("setupKey")]
        public string SetupKey { get; set; }
    }
}