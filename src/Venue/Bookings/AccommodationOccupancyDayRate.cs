using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class AccommodationOccupancyDayRate : AccommodationDayRate
    {
        [JsonProperty("occType")]
        public int OccupancyType
        {
            get; set;
        }
    }
}
