using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Invoice
{
    public class InvoiceResult: ISerializable
    {
        [JsonProperty("invoiceRefTypes")]
        public string InvoiceRefTypes { get; set; }

        [JsonProperty("invoiceLineRefTypes")]
        public string InvoiceLineRefTypes { get; set; }

        [JsonProperty("paymentMethods")]
        public string PaymentMethods { get; set; }
    }
}
