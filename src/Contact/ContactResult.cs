using Newtonsoft.Json;

namespace Ivvy.Contact
{
    /// <summary>
    /// The result of adding or updating a contact.
    /// </summary>
    public sealed class ContactResult : Ivvy.Json.ISerializable
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}