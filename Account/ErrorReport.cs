using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Account
{
    public class ErrorReport : ISerializable
    {
        public enum RefTypes
        {
            Custom = 1,
            VenueBooking = 2,
            VenueBookingAccommodation = 3,
            VenueBookingRoomReservation = 4,
        }

        public enum Levels
        {
            Critical = 1,
            High = 2,
            Medium = 3,
            Low = 4,
            Lowest = 5,
        }

        [JsonProperty("refType")]
        public RefTypes RefType { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("level")]
        public Levels Level { get; set; }

        [JsonProperty("refId1")]
        public int? RefId1 { get; set; }

        [JsonProperty("refId2")]
        public int? RefId2 { get; set; }

        [JsonProperty("refId3")]
        public int? RefId3 { get; set; }

        [JsonProperty("refId4")]
        public int? RefId4 { get; set; }

        [JsonProperty("refId5")]
        public int? RefId5 { get; set; }
    }
}