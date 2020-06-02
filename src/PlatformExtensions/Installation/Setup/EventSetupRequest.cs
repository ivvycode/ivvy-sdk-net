using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Installation.Setup
{
    /// <summary>
    /// This class encapsulates the details sent by iVvy to an extension
    /// when it is added to an event within a client account.
    /// </summary>
    public sealed class EventSetupRequest
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

        [JsonProperty("eventId")]
        public string EventId
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