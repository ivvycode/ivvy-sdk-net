using System;
using Newtonsoft.Json;

namespace Ivvy.API.Invoice
{
    public class InvoicePayment
    {
        public enum PaymentMethods
        {
            Unknown = 0,
            CreditCard = 1,
            BPay = 2,
            DirectDeposit = 3,
            PayPal = 4,
            Cheque = 5,
            Cash = 6,
            CustomPaymentGateway = 7,
            AccountsReceivable = 8,
            Eftpos = 9,
            WriteOff = 10,
            Pos = 11,
            WireTransfer = 12,
            Custom = 13
        }

        public enum CardTypes
        {
            Unknown = 0,
            Visa = 1,
            Master = 2,
            Amex = 3,
            Diners = 4
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("paymentId")]
        public string PaymentId
        {
            get; set;
        }

        [JsonProperty("receiptNum")]
        public string ReceiptNumber
        {
            get; set;
        }

        [JsonProperty("amountPaid")]
        public float? AmountPaid
        {
            get; set;
        }

        [JsonProperty("notes")]
        public string Notes
        {
            get; set;
        }

        [JsonProperty("chequeNumber")]
        public string ChequeNumber
        {
            get; set;
        }

        [JsonProperty("paymentMethod")]
        public int PaymentMethod
        {
            get; set;
        }

        [JsonProperty("paidDate")]
        public DateTime? PaidDate
        {
            get; set;
        }
    }
}