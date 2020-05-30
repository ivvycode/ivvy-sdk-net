using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Contact
{
    public class Agent : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("businessName")]
        public string BusinessName
        {
            get; set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get; set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get; set;
        }
    }
}