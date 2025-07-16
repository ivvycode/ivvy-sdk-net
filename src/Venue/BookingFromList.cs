using System;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class BookingFromList : BookingBase
    {
        // Missing:
        // totalAttendees (in "getBooking" but the value is different)
        // lastModifiedDate
        // convertedToTentative
        // convertedToConfirmed
        // convertedToCancelled
        // convertedToProspectiveHold
        // focRoomsDenominator
        // maxNumFocRoomsPerDay
        // beoNumbers
        // accommCancellationDate
        // accommChargingMethod
        // accommGuaranteeRequired
        // revenueTemplateId

        [JsonProperty("company")]
        public Bookings.CompanyRef Company
        {
            get; set;
        }

        [JsonProperty("contact")]
        public Bookings.ContactRef Contact
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
        public DateTime? CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime? ModifiedDate
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

        [JsonProperty("hasCommissions")]
        public bool HasCommissions
        {
            get; set;
        }

        [JsonProperty("hasCommissionPaid")]
        public bool HasCommissionPaid
        {
            get; set;
        }

        [JsonProperty("agentCompanyId")]
        public int? AgentCompanyId
        {
            get; set;
        }

        [JsonProperty("agentCompany")]
        public Bookings.CompanyRef AgentCompany
        {
            get; set;
        }

        [JsonProperty("agentContactId")]
        public int? AgentContactId
        {
            get; set;
        }

        [JsonProperty("agentContact")]
        public Bookings.ContactRef AgentContact
        {
            get; set;
        }

        [JsonProperty("commissionAccommodationType")]
        public CommissionTypes? CommissionAccommodationType
        {
            get; set;
        }

        [JsonProperty("commissionAccommodation")]
        public float? CommissionAccommodation
        {
            get; set;
        }

        [JsonProperty("commissionSpaceType")]
        public CommissionTypes? CommissionSpaceType
        {
            get; set;
        }

        [JsonProperty("commissionSpace")]
        public float? CommissionSpace
        {
            get; set;
        }

        [JsonProperty("commissionFoodType")]
        public CommissionTypes? CommissionFoodType
        {
            get; set;
        }

        [JsonProperty("commissionFood")]
        public float? CommissionFood
        {
            get; set;
        }

        [JsonProperty("commissionBeverageType")]
        public CommissionTypes? CommissionBeverageType
        {
            get; set;
        }

        [JsonProperty("commissionBeverage")]
        public float? CommissionBeverage
        {
            get; set;
        }

        [JsonProperty("commissionAudioVisualType")]
        public CommissionTypes? CommissionAudioVisualType
        {
            get; set;
        }

        [JsonProperty("commissionAudioVisual")]
        public float? CommissionAudioVisual
        {
            get; set;
        }

        public virtual BookingMutable InitMutableBooking()
        {
            return new BookingMutable
            {
                Id = Id,
                VenueId = VenueId,
                LeadId = LeadId,
                Code = Code,
                OtaFolioReference = OtaFolioReference,
                Name = Name,
                CompanyId = CompanyId,
                ContactId = ContactId,
                CurrentStatus = CurrentStatus,
                BookingType = BookingType,
                DateEventStart = DateEventStart,
                DateEventEnd = DateEventEnd,
                IsAccommIncluded = IsAccommIncluded,
                DateAccomStart = DateAccomStart,
                DateAccomEnd = DateAccomEnd,
                AccommCutOffDate = AccommCutOffDate,
                EventTypeId = EventTypeId,
                AccommExternalBlockId = AccommExternalBlockId,
                BookedById = BookedById,
                IsConfidential = IsConfidential,
                CanBeMoved = CanBeMoved,
                AccommodationReservationMethods = AccommodationReservationMethods,
            };
        }
    }
}