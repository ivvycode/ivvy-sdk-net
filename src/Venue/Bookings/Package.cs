using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Booking Package details on an iVvy venue booking.
    /// </summary>
    public class Package : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("price")]
        public decimal Price
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

        [JsonProperty("smallDescription")]
        public string SmallDescription
        {
            get; set;
        }

        [JsonProperty("costcenters")]
        public PackageCostCenter[] CostCenters
        {
            get; set;
        }

    }
}