using Newtonsoft.Json;

namespace Ivvy.API.Contact
{
    /// <summary>
    /// The result of adding or updating a contact.
    /// </summary>
    public sealed class ContactResult : Ivvy.API.Json.ISerializable
    {
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }

        [JsonProperty("message")]
        public string Message
        {
            get; set;
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }
    }
}