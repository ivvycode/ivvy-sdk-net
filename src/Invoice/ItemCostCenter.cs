using Newtonsoft.Json;

namespace Ivvy.API.Invoice
{
    public class ItemCostCenter
    {
        [JsonProperty("costcenterId")]
        public int CostCenterId
        {
            get; set;
        }

        [JsonProperty("totalCost")]
        public decimal TotalCost
        {
            get; set;
        }

        [JsonProperty("totalTaxCost")]
        public decimal TotalTaxCost
        {
            get; set;
        }
    }
}