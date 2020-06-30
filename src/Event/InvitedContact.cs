using System;
using Newtonsoft.Json;

namespace Ivvy.API.Event
{
    public class InvitedContact
    {
        [JsonProperty("contactId")]
        public int ContactId
        {
            get; set;
        }

        [JsonProperty("eventId")]
        public int EventId
        {
            get; set;
        }

        [JsonProperty("firstName")]
        public string FirstName
        {
            get; set;
        }

        [JsonProperty("lastName")]
        public string LastName
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

        [JsonProperty("response")]
        public string Response
        {
            get; set;
        }

        [JsonProperty("registrationId")]
        public int? RegistrationId
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate
        {
            get; set;
        }
    }
}