using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Venue
{
    /// <summary>
    /// The contact details of a venue guest.
    /// </summary>
    public class GuestContact : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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