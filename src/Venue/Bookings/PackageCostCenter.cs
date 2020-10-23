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
        public decimal Value
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount
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