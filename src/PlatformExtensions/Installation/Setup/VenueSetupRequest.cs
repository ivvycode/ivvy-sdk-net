using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Installation.Setup
{
    /// <summary>
    /// This class encapsulates the details sent by iVvy to an extension
    /// when it is added to a venue within a client account.
    /// </summary>
    public sealed class VenueSetupRequest
    {
        [JsonProperty("region")]
        public string Region
        {
            get; set;
        }

        [JsonProperty("accountId")]
        public string AccountId
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public string VenueId
        {
            get; set;
        }

        [JsonProperty("setupKey")]
        public string SetupKey
        {
            get; set;
        }
    }
}