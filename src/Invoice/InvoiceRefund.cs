using System;
using Newtonsoft.Json;

namespace Ivvy.API.Invoice
{
    public class InvoiceRefund
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("invoiceId")]
        public int InvoiceId
        {
            get; set;
        }

        [JsonProperty("refundId")]
        public int RefundId
        {
            get; set;
        }

        [JsonProperty("refundDate")]
        public DateTime RefundDate
        {
            get; set;
        }

        [JsonProperty("notes")]
        public string Notes
        {
            get; set;
        }

        [JsonProperty("amountRefunded")]
        public decimal AmountRefunded
        {
            get; set;
        }

        [JsonProperty("refundMethodId")]
        public int? RefundMethodId
        {
            get; set;
        }
    }
}