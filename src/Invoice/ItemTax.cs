using Newtonsoft.Json;

namespace Ivvy.API.Invoice
{
    public class ItemTax
    {
        public enum TaxRateAmountTypeOptions
        {
            Percentage = 1,
            Amount = 2
        }

        [JsonProperty("taxId")]
        public int TaxId
        {
            get; set;
        }

        [JsonProperty("amount")]
        public float Amount
        {
            get; set;
        }

        [JsonProperty("taxRateId")]
        public int? TaxRateId
        {
            get; set;
        }

        [JsonProperty("taxRateAmount")]
        public float TaxRateAmount
        {
            get; set;
        }

        [JsonProperty("taxRateAmountType")]
        public TaxRateAmountTypeOptions TaxRateAmountType
        {
            get; set;
        }

        [JsonProperty("costCenterId")]
        public int? CostCenterId
        {
            get; set;
        }
    }
}