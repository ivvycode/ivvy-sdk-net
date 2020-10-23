using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of an additional item on a venue booking.
    /// </summary>
    public class AdditionalItem : ISerializable
    {
        [JsonProperty("id")]
        public int Id
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

        [JsonProperty("includeInPackage")]
        public bool IncludeInPackage
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalcost")]
        public decimal TotalCost
        {
            get; set;
        }

        [JsonProperty("actualcost")]
        public decimal ActualCost
        {
            get; set;
        }

        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount
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