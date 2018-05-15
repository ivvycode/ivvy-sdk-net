using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.EventRegistration
{
    public class EventRegistration : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("eventId")]
        public int EventId { get; set; }

        [JsonProperty("currentStatus")]
        public int CurrentStatus { get; set; }

        [JsonProperty("isExhibitor")]
        public bool IsExhibitor { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }
    }
}
