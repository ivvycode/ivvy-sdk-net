using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Venue
{
    public class Booking : ISerializable
    {
        public enum StatusOptions
        {
            Prospective = 1,
            Tentative = 2,
            Confirmed = 3,
            Cancelled = 4,
            Ordering = 5,
            NotAccepted = 6
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("venueId")]
        public int VenueId { get; set; }

        [JsonProperty("venueName")]
        public string VenueName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("companyId")]
        public int? CompanyId { get; set; }

        [JsonProperty("company")]
        public Contact.Company Company { get; set; }

        [JsonProperty("contactId")]
        public int? ContactId { get; set; }

        [JsonProperty("contact")]
        public Contact.Contact Contact { get; set; }

        [JsonProperty("currentStatus")]
        public StatusOptions CurrentStatus { get; set; }

        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public float TotalTaxAmount { get; set; }

        [JsonProperty("amountOutstanding")]
        public float AmountOutstanding { get; set; }

        [JsonProperty("accountTimezone")]
        public string AccountTimezone { get; set; }

        [JsonProperty("venueTimezone")]
        public string VenueTimezone { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate { get; set; }

        [JsonProperty("dateEventStart")]
        public DateTime DateEventStart { get; set; }

        [JsonProperty("dateEventEnd")]
        public DateTime DateEventEnd { get; set; }

        [JsonProperty("isAccommIncluded")]
        public bool IsAccommIncluded { get; set; }

        [JsonProperty("dateAccomStart")]
        public DateTime? DateAccomStart { get; set; }

        [JsonProperty("dateAccomEnd")]
        public DateTime? DateAccomEnd { get; set; }

        [JsonProperty("hasPackages")]
        public bool HasPackages { get; set; }

        [JsonProperty("decisionDate")]
        public DateTime? DecisionDate { get; set; }

        [JsonProperty("isBeoFinalised")]
        public bool IsBeoFinalised { get; set; }

        [JsonProperty("beoFinalisedDate")]
        public DateTime? BeoFinalisedDate { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("dailyRevenue")]
        public Bookings.DailyRevenue[] DailyRevenues { get; set; }
    }
}
