using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A description of tax applied to a booking item.
    /// </summary>
    public class TaxDetail : ISerializable
    {
        [JsonProperty("id")]
        public int TaxId
        {
            get; set;
        }

        [JsonProperty("tax")]
        public decimal TaxAmount
        {
            get; set;
        }
    }
}