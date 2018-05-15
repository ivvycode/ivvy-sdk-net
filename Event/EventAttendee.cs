using Ivvy.Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ivvy.EventAttendee
{
    public class EventAttendee : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("registrationStatus")]
        public int RegistrationStatus { get; set; }

        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("ticketTitle")]
        public string TicketTitle { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hasAttended")]
        public bool HasAttended { get; set; }

        [JsonProperty("sessionHasAttended")]
        public bool SessionHasAttended { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("barcodeUrl")]
        public string BarcodeUrl { get; set; }

        [JsonProperty("ticketUrl")]
        public string TicketUrl { get; set; }

        [JsonProperty("attendedDatetime")]
        public string AttendedDatetime { get; set; }

        [JsonProperty("sessionAttendedTimestamp")]
        public string SessionAttendedTimestamp { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("customFields")]
        public List<CustomField> CustomFields { get; set; }

        [JsonProperty("eventId")]
        public int EventId { get; set; }
    }

    public class CustomField : ISerializable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
