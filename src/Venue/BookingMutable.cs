using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class BookingMutable : BookingBase
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
        public new int Id
        {
            get; set;
        }

        [JsonProperty("company")]
        public Contact.Company Company
        {
            get; set;
        }

        [JsonProperty("contact")]
        public Contact.Contact Contact
        {
            get; set;
        }

        [JsonProperty("bookingType")]
        public Booking.BookingTypeOptions BookingType
        {
            get; set;
        }

        [JsonProperty("totalAttendees")]
        public int? TotalAttendees
        {
            get; set;
        }

        [JsonProperty("leadId")]
        public int? LeadId
        {
            get; set;
        }
    }
}