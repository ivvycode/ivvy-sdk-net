using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Contact
{
    public class Agent : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
