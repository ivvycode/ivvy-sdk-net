using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Account
{
    /// <summary>
    /// The result of subscribing to account notifications.
    /// </summary>
    public class NotificationsResult : ISerializable
    {
        [JsonProperty("eventsSuccess")]
        public bool EventsSuccess { get; set; }

        [JsonProperty("eventsTopicId")]
        public string EventsTopicId { get; set; }

        [JsonProperty("venuesSuccess")]
        public bool VenuesSuccess { get; set; }

        [JsonProperty("venuesTopicId")]
        public string VenuesTopicId { get; set; }
    }
}