using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public abstract class BookingBase : ISerializable
    {
        public enum StatusOptions
        {
            Prospective = 1,
            Tentative = 2,
            Confirmed = 3,
            Cancelled = 4,
            Ordering = 5,
            NotAccepted = 6,
            ProspectiveHold = 9
        }

        public enum BookingTypeOptions
        {
            Detailed = 1,
            AccommodationOnly = 4
        }

        public enum AccommodationReservationMethodOptions
        {
            RoomingList = 1,
            IndividualCallIn = 2,
            BookingEngine = 3,
            HousingForm = 4
        }

        public enum CommissionTypes
        {
            Fixed = 1,
            Percentage = 2
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("leadId")]
        public int? LeadId
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

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public Booking.StatusOptions CurrentStatus
        {
            get; set;
        }

        [JsonProperty("bookingType")]
        public BookingTypeOptions BookingType
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

        [JsonProperty("accommCutOffDate", NullValueHandling = NullValueHandling.Include)]
        public DateTime? AccommCutOffDate
        {
            get; set;
        }

        [JsonProperty("eventTypeId")]
        public int? EventTypeId
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

        [JsonProperty("accommReservationMethod")]
        public AccommodationReservationMethodOptions[] AccommodationReservationMethods
        {
            get; set;
        }
    }
}
