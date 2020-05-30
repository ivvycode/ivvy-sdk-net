using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Configure
{
    /// <summary>
    /// This class encapsulates the details required by iVvy when
    /// an extension calls the venue configure endpoint.
    /// </summary>
    public sealed class VenueConfigureRequest
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("venueId")]
        public string VenueId { get; set; }

        [JsonProperty("setupKey")]
        public string SetupKey { get; set; }
    }
}