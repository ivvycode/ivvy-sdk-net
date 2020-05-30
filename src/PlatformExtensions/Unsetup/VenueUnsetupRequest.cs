using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Unsetup
{
    /// <summary>
    /// This class encapsulates the details sent by iVvy to an extension
    /// when it is removed from a client venue.
    /// </summary>
    public sealed class VenueUnsetupRequest
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("venueId")]
        public string VenueId { get; set; }

        [JsonProperty("setupKey")]
        public string SetupKey { get; set; }
    }
}