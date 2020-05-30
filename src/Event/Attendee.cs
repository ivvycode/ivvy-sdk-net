using Ivvy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ivvy.Event
{
    public class Attendee : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("eventId")]
        public int EventId
        {
            get; set;
        }

        [JsonProperty("registrationStatus")]
        public Registration.StatusOptions RegistrationStatus
        {
            get; set;
        }

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("ticketTitle")]
        public string TicketTitle
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

        [JsonProperty("hasAttended")]
        public bool HasAttended
        {
            get; set;
        }

        [JsonProperty("sessionHasAttended")]
        public bool SessionHasAttended
        {
            get; set;
        }

        [JsonProperty("isPublic")]
        public bool IsPublic
        {
            get; set;
        }

        [JsonProperty("barcode")]
        public string Barcode
        {
            get; set;
        }

        [JsonProperty("barcodeUrl")]
        public string BarcodeUrl
        {
            get; set;
        }

        [JsonProperty("ticketUrl")]
        public string TicketUrl
        {
            get; set;
        }

        [JsonProperty("attendedDatetime")]
        public DateTime? AttendedDatetime
        {
            get; set;
        }

        [JsonProperty("sessionAttendedTimestamp")]
        public DateTime? SessionAttendedTimestamp
        {
            get; set;
        }

        [JsonProperty("cost")]
        public float Cost
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate
        {
            get; set;
        }

        [JsonProperty("customFields")]
        public List<CustomField> CustomFields
        {
            get; set;
        }
    }

    /// <summary>
    /// An attendee's custom field value.
    /// </summary>
    public class CustomField : ISerializable
    {
        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("value")]
        public object Value
        {
            get; set;
        }
    }
}