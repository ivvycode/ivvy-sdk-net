using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class PackageCostCenter
    {
        [JsonProperty("costcenterId")]
        public int CostCenterId
        {
            get; set;
        }

        [JsonProperty("value")]
        public double Value
        {
            get; set;
        }

        [JsonProperty("discount")]
        public double Discount
        {
            get; set;
        }

        [JsonProperty("surcharge")]
        public double Surcharge
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public int[] ExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public double TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalSurcharge")]
        public double TotalSurcharge
        {
            get; set;
        }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount
        {
            get; set;
        }

        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
        {
            get; set;
        }
    }
}