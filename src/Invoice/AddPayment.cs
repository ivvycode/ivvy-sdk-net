using Newtonsoft.Json;
using System;

namespace Ivvy.Invoice
{
    /// <summary>
    /// Object that can be used to add a payment to an invoice.
    /// </summary>
    public class AddPayment
    {
        [JsonProperty("invoiceId")]
        public int InvoiceId
        {
            get; set;
        }

        [JsonProperty("receiptNum")]
        public string ReceiptNum
        {
            get; set;
        }

        [JsonProperty("amountPaid")]
        public float AmountPaid
        {
            get; set;
        }

        [JsonProperty("paymentMethod")]
        public InvoicePayment.PaymentMethods PaymentMethod
        {
            get; set;
        }

        [JsonProperty("paidDate")]
        public DateTime PaidDate
        {
            get; set;
        }

        [JsonProperty("reconciledDate")]
        public DateTime? ReconciledDate
        {
            get; set;
        }

        [JsonProperty("notes")]
        public string Notes
        {
            get; set;
        }

        [JsonProperty("cardType")]
        public InvoicePayment.CardTypes CardType
        {
            get; set;
        }

        [JsonProperty("feePercentage")]
        public decimal? FeePercentage
        {
            get; set;
        }

        [JsonProperty("chequeNumber")]
        public string ChequeNumber
        {
            get; set;
        }

        [JsonProperty("chequeDrawerName")]
        public string ChequeDrawerName
        {
            get; set;
        }

        [JsonProperty("chequeBankBranch")]
        public string ChequeBankBranch
        {
            get; set;
        }

        [JsonProperty("eftTransferDate")]
        public DateTime? EftTransferDate
        {
            get; set;
        }

        [JsonProperty("eftPaymentReference")]
        public string EftPaymentReference
        {
            get; set;
        }
    }
}