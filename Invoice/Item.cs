using Newtonsoft.Json;

namespace Ivvy.Invoice
{
    public class Item
    {
        [JsonProperty("refType")]
        public string RefType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        [JsonProperty("unitCost")]
        public float UnitCost { get; set; }

        [JsonProperty("totalCost")]
        public float TotalCost { get; set; }

        [JsonProperty("totalTaxCost")]
        public float TotalTaxCost { get; set; }

        [JsonProperty("amountPaid")]
        public float AmountPaid { get; set; }
    }
}
