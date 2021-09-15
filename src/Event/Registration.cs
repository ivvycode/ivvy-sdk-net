using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Event
{
    public class Registration : ISerializable
    {
        public enum StatusOptions
        {
            InProgress = 1,
            Completed = 2,
            Cancelled = 3,
            Payment = 4,
            Deleted = 5,
            Checkout = 6,
            Incomplete = 7
        }

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

        [JsonProperty("currentStatus")]
        public StatusOptions CurrentStatus
        {
            get; set;
        }

        [JsonProperty("isExhibitor")]
        public bool IsExhibitor
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

        [JsonProperty("eventName")]
        public string EventName
        {
            get; set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime? ModifiedDate
        {
            get; set;
        }

        [JsonProperty("completedDate")]
        public DateTime? CompletedDate
        {
            get; set;
        }

        [JsonProperty("mainContactId")]
        public int MainContactId
        {
            get; set;
        }

        [JsonProperty("invoiceTotalCost")]
        public double InvoiceTotalCost
        {
            get; set;
        }

        [JsonProperty("invoiceTotalPaid")]
        public double InvoiceTotalPaid
        {
            get; set;
        }
    }
}