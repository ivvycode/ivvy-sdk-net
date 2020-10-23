using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
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

        public enum BookingTypeOptions
        {
            Detailed = 1,
            AccommodationOnly = 4
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("venueName")]
        public string VenueName
        {
            get; set;
        }

        [JsonProperty("code")]
        public string Code
        {
            get; set;
        }

        [JsonProperty("otaFolioRef")]
        public string OtaFolioReference
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("companyId")]
        public int? CompanyId
        {
            get; set;
        }

        [JsonProperty("company")]
        public Contact.Company Company
        {
            get; set;
        }

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("contact")]
        public Contact.Contact Contact
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public StatusOptions CurrentStatus
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public float TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalTaxAmount")]
        public float TotalTaxAmount
        {
            get; set;
        }

        [JsonProperty("amountOutstanding")]
        public float AmountOutstanding
        {
            get; set;
        }

        [JsonProperty("accountTimezone")]
        public string AccountTimezone
        {
            get; set;
        }

        [JsonProperty("venueTimezone")]
        public string VenueTimezone
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate
        {
            get; set;
        }

        [JsonProperty("dateEventStart")]
        public DateTime? DateEventStart
        {
            get; set;
        }

        [JsonProperty("dateEventEnd")]
        public DateTime? DateEventEnd
        {
            get; set;
        }

        [JsonProperty("isAccommIncluded")]
        public bool IsAccommIncluded
        {
            get; set;
        }

        [JsonProperty("dateAccomStart")]
        public DateTime? DateAccomStart
        {
            get; set;
        }

        [JsonProperty("dateAccomEnd")]
        public DateTime? DateAccomEnd
        {
            get; set;
        }

        [JsonProperty("hasPackages")]
        public bool HasPackages
        {
            get; set;
        }

        [JsonProperty("decisionDate")]
        public DateTime? DecisionDate
        {
            get; set;
        }

        [JsonProperty("isBeoFinalised")]
        public bool IsBeoFinalised
        {
            get; set;
        }

        [JsonProperty("beoFinalisedDate")]
        public DateTime? BeoFinalisedDate
        {
            get; set;
        }

        [JsonProperty("eventType")]
        public string EventType
        {
            get; set;
        }

        [JsonProperty("eventTypeId")]
        public int? EventTypeId
        {
            get; set;
        }

        [JsonProperty("bookingType")]
        public BookingTypeOptions BookingType
        {
            get; set;
        }

        [JsonProperty("accommExternalBlockId")]
        public string AccommExternalBlockId
        {
            get; set;
        }

        [JsonProperty("bookedById")]
        public int? BookedById
        {
            get; set;
        }

        [JsonProperty("totalAttendees")]
        public int? TotalAttendees
        {
            get; set;
        }

        [JsonProperty("isConfidential")]
        public bool IsConfidential
        {
            get; set;
        }

        [JsonProperty("canBeMoved")]
        public bool CanBeMoved
        {
            get; set;
        }

        [JsonProperty("dailyRevenue")]
        public Bookings.DailyRevenue[] DailyRevenues
        {
            get; set;
        }

        [JsonProperty("packages")]
        public Bookings.Package[] Packages
        {
            get; set;
        }

        [JsonProperty("sessions")]
        public Bookings.Session[] Sessions
        {
            get; set;
        }

        [JsonProperty("menus")]
        public Bookings.Menu[] Menus
        {
            get; set;
        }

        [JsonProperty("beveragePackages")]
        public Bookings.BeveragePackage[] BeveragePackages
        {
            get; set;
        }

        [JsonProperty("resources")]
        public Bookings.Resource[] Resources
        {
            get; set;
        }

        [JsonProperty("products")]
        public Bookings.Product[] Products
        {
            get; set;
        }

        [JsonProperty("additionalItems")]
        public Bookings.AdditionalItem[] AdditionalItems
        {
            get; set;
        }

        [JsonProperty("agent")]
        public Contact.Agent Agent
        {
            get; set;
        }

        [JsonProperty("opportunityId")]
        public int? OpportunityId
        {
            get; set;
        }
    }
}