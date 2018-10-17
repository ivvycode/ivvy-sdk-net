using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Venue.Bookings
{
    /// <summary>
    /// A daily rate for an accommodation room reservation on an iVvy venue booking.
    /// </summary>
    public class RoomReservationDayRate : ISerializable
    {
        [JsonProperty("dayDate")]
        public string DayDate { get; set; }

        [JsonProperty("barId")]
        public int? RatePlanId { get; set; }

        [JsonProperty("cost")]
        public float? Cost { get; set; }
    }
}