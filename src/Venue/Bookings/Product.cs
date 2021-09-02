using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a product on a venue booking session.
    /// </summary>
    public class Product : SessionablePackageableBookingItem
    {
        [JsonProperty("quantity")]
        public int Quantity
        {
            get; set;
        }
    }
}