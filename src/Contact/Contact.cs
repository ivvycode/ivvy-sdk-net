using Newtonsoft.Json;
using Ivvy.Json;

namespace Ivvy.Contact
{
    /// <summary>
    /// An iVVy contact.
    /// </summary>
    public class Contact : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}