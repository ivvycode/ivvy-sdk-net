using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// An iVvy venue booking tax.
    /// </summary>
    public class BookingTax
    {
        public enum AmountTypeOptions
        {
            Percentage = 1,
            Amount = 2
        }

        public enum TypeOptions
        {
            Tax = 1,
            ServiceFees = 2
        }

        public enum AppliesToOptions
        {
            All = 1,
            AccommodationOnly = 2
        }

        public enum UnitTypeOptions
        {
            RoomNights = 1,
            Capacity = 2,
            Occupancy = 3
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

        [JsonProperty("bookingId")]
        public int BookingId
        {
            get; set;
        }

        [JsonProperty("venueTaxId")]
        public int VenueTaxId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("type")]
        public TypeOptions Type
        {
            get; set;
        }

        [JsonProperty("appliesTo")]
        public AppliesToOptions AppliesTo
        {
            get; set;
        }

        [JsonProperty("amountType")]
        public AmountTypeOptions AmountType
        {
            get; set;
        }

        [JsonProperty("amount")]
        public float? Amount
        {
            get; set;
        }

        [JsonProperty("taxIds")]
        public int[] TaxIds
        {
            get; set;
        }

        [JsonProperty("costcenterIds")]
        public int[] CostCenterIds
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public int[] ExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("calculateExclusively")]
        public bool CalculateExclusively
        {
            get; set;
        }

        [JsonProperty("unitType")]
        public UnitTypeOptions UnitType
        {
            get; set;
        }
    }
}
