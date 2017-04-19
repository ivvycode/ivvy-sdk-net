using Newtonsoft.Json;

namespace Ivvy.Extensions.Setup
{
    /// <summary>
    /// This class encapsulates the details returned by iVvy when
    /// an extension verifies a setup request.
    /// </summary>
    public class VerifySetupResponse
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("apiSecret")]
        public string ApiSecret { get; set; }
    }
}