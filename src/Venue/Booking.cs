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

        [JsonProperty("totalAttendees")]
        public int? TotalAttendees
        {
            get; set;
        }

        private int? opportunityId;

        [JsonProperty("opportunityId")]
        public int? OpportunityId
        {
            get => opportunityId;
            set
            {
                opportunityId = value;
                LeadId = value;
            }
        }

        [JsonIgnore]
        public new int? LeadId
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
            mutable.TotalAttendees = TotalAttendees;
            return mutable;
        }
    }
}