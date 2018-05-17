using Newtonsoft.Json;

namespace Ivvy.Extensions.Unsetup
{
    /// <summary>
    /// This class encapsulates the details sent by iVvy to an extension
    /// when it is removed from a client account.
    /// </summary>
    public sealed class UnsetupRequest
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("setupKey")]
        public string SetupKey { get; set; }
    }
}