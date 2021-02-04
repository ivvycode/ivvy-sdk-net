using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A daily rate for a group accommodation block on an iVvy venue booking.
    /// </summary>
    public class AccommodationDayRate : ISerializable
    {
        [JsonProperty("bookingDate")]
        public string BookingDate
        {
            get; set;
        }

        [JsonProperty("numRooms")]
        public int NumRooms
        {
            get; set;
        }

        [JsonProperty("cost")]
        public float? Cost
        {
            get; set;
        }

        [JsonProperty("numPayableByGuest")]
        public int NumPayableByGuest
        {
            get; set;
        }

        [JsonProperty("numFreeRooms")]
        public int? NumFreeRooms
        {
            get; set;
        }
    }
}