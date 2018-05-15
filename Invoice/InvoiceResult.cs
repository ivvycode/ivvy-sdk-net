using Newtonsoft.Json;

namespace Ivvy.Invoice
{
    /// <summary>
    /// The result of adding or updating a contact.
    /// </summary>
    public sealed class InvoiceResult : Json.ISerializable
    {
        [JsonProperty("invoiceRefTypes")]
        public string InvoiceRefTypes { get; set; }

        [JsonProperty("invoiceLineRefTypes")]
        public string InvoiceLineRefTypes { get; set; }

        [JsonProperty("paymentMethods")]
        public string PaymentMethods { get; set; }
    }
}