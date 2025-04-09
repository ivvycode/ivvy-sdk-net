using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A daily rate for an accommodation room reservation on an iVvy venue booking.
    /// </summary>
    public class RoomReservationDayRate : ISerializable
    {
        [JsonProperty("dayDate")]
        public string DayDate
        {
            get; set;
        }

        [JsonProperty("barId")]
        public int? RatePlanId
        {
            get; set;
        }

        [JsonProperty("cost")]
        public float? Cost
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public float? TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalTaxAmount")]
        public float? TotalTaxAmount
        {
            get; set;
        }
    }
}