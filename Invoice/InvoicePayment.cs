using Newtonsoft.Json;
using System;

namespace Ivvy.Invoice
{
    public class InvoicePayment
    {
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }

        [JsonProperty("receiptNum")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("amountPaid")]
        public decimal? AmountPaid { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("chequeNumber")]
        public string ChequeNumber { get; set; }

        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paidDate")]
        public DateTime? PaidDate { get; set; }
    }
}
