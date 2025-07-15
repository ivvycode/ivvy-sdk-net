using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class BookingMutable : ISerializable
    {
        // Missing:
        // purchaseOrderNumber
        // industryId
        // packageId
        // packagePrice
        // accommCancellationDate
        // accommChargingMethod
        // accommGuaranteeRequired
        // accommReservationCancellationDate
        // accommArrivalMethod
        // bookingRoleUserId1
        // bookingRoleUserId2
        // bookingRoleUserId3
        // bookingRoleUserId4
        // bookingRoleUserId5
        // customFields
        // discountCode
        // externalUrls

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
        public Booking.StatusOptions CurrentStatus
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

        [JsonProperty("bookingType")]
        public Booking.BookingTypeOptions BookingType
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

        [JsonProperty("leadId")]
        public int? LeadId
        {
            get; set;
        }

        [JsonProperty("accommReservationMethod")]
        public Booking.AccommodationReservationMethodOptions[] AccommodationReservationMethods
        {
            get; set;
        }
    }
}