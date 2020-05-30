using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Configure
{
    /// <summary>
    /// This class encapsulates the details required by iVvy when
    /// an extension calls the event configure endpoint.
    /// </summary>
    public sealed class EventConfigureRequest
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("setupKey")]
        public string SetupKey { get; set; }
    }
}