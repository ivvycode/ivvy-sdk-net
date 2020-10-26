using Newtonsoft.Json;

namespace Ivvy.API.Invoice
{
    public class Item
    {
        public enum RefTypes
        {
            Unknown = 0,
            Fee = 100,
            CardFee = 102,
            PaymentFee = 103,
            Deposit = 500,
            Package = 501,
            Invoice = 502,
            Payment = 503,
            FinalInvoiceAdjustment = 504,
            Session = 505,
            MenuPackage = 506,
            BeveragePackage = 507,
            Resource = 508,
            Product = 509,
            Accommodation = 510,
            AdditionalItem = 511,
            ServiceFee = 513
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("refType")]
        public int RefType
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("quantity")]
        public float Quantity
        {
            get; set;
        }

        [JsonProperty("unitCost")]
        public float UnitCost
        {
            get; set;
        }

        [JsonProperty("totalCost")]
        public float TotalCost
        {
            get; set;
        }

        [JsonProperty("totalTaxCost")]
        public float TotalTaxCost
        {
            get; set;
        }

        [JsonProperty("amountPaid")]
        public float? AmountPaid
        {
            get; set;
        }

        [JsonProperty("costCenters")]
        public ItemCostCenter[] CostCenters
        {
            get; set;
        }

        [JsonProperty("taxes")]
        public ItemTax[] Taxes
        {
            get; set;
        }
    }
}