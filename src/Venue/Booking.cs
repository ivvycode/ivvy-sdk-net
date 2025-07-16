using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class Booking : BookingFromList
    {
        // Missing:
        // lastModifiedDate
        // convertedToTentative
        // convertedToConfirmed
        // convertedToCancelled
        // convertedToProspectiveHolds
        // focRoomsDenominator
        // maxNumFocRoomsPerDay
        // beoNumbers
        // accommCancellationDate
        // accommChargingMethod
        // accommGuaranteeRequired
        // revenueTemplateId
        // customFields
        // salesPersonUser
        // bookedByUser
        // leadBccEmail
        // foodBeveragePayableBy
        // hasCateringWebsite
        // cateringWebsiteLogoId
        // cateringWebsiteLogo
        // cateringWebsiteBannerId
        // cateringWebsiteBanner
        // cateringWebsiteEventDesc
        // cateringWebsiteEndNumDays
        // externalUrls

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

        [JsonProperty("bookingType")]
        public BookingTypeOptions BookingType
        {
            get; set;
        }

        [JsonProperty("totalAttendees")]
        public int? TotalAttendees
        {
            get; set;
        }

        [JsonProperty("opportunityId")]
        public int? OpportunityId
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

        [JsonProperty("serviceFees")]
        public Bookings.ServiceFee[] ServiceFees
        {
            get; set;
        }

        [JsonProperty("agent")]
        public Contact.Agent Agent
        {
            get; set;
        }

        [JsonProperty("commissionByCostCentres")]
        public Bookings.CostCentreCommission[] CostCentreCommissions
        {
            get; set;
        }

        public override BookingMutable InitMutableBooking()
        {
            var mutable = base.InitMutableBooking();
            mutable.LeadId = OpportunityId;
            mutable.BookingType = BookingType;
            mutable.TotalAttendees = TotalAttendees;
            return mutable;
        }
    }
}