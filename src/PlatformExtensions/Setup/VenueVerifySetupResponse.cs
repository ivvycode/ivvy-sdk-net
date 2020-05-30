using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Setup
{
    /// <summary>
    /// This class encapsulates the details returned by iVvy when
    /// an extension verifies a venue setup request.
    /// </summary>
    public sealed class VenueVerifySetupResponse
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountDomain")]
        public string AccountDomain { get; set; }

        [JsonProperty("venueId")]
        public string VenueId { get; set; }

        [JsonProperty("venueHashId")]
        public string VenueHashId { get; set; }
    }
}