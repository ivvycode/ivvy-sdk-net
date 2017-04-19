using Newtonsoft.Json;

namespace Ivvy.Extensions.Setup
{
    /// <summary>
    /// This class encapsulates the details sent by iVvy to an extension
    /// when it is added to a client account.
    /// </summary>
    public sealed class SetupRequest
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("setupKey")]
        public string SetupKey { get; set; }
    }
}