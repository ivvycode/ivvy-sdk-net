using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a product on a venue booking session.
    /// </summary>
    public class Product : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("sessionId")]
        public int SessionId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("quantity")]
        public int Quantity
        {
            get; set;
        }

        [JsonProperty("includeInPackage")]
        public bool IncludeInPackage
        {
            get; set;
        }

        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount
        {
            get; set;
        }

        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
        {
            get; set;
        }
    }
}