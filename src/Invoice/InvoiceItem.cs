using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Ivvy.Invoice
{
    public class InvoiceItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("unitCost")]
        public string UnitCost { get; set; }

        [JsonProperty("totalCost")]
        public string TotalCost { get; set; }

        [JsonProperty("totalTaxCost")]
        public string TotalTaxCost { get; set; }

        [JsonProperty("amountPaid")]
        public string AmountPaid { get; set; }

        [JsonProperty("refType")]
        public string RefType { get; set; }
    }
}
