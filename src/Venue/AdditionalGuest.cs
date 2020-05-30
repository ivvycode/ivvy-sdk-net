using Ivvy.Common;
using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Venue
{
    /// <summary>
    /// An additional guest can be assigned to an accommodation room reservation on an iVvy venue booking.
    /// </summary>
    public class AdditionalGuest : ISerializable
    {
        public enum GuestTypes {
            Sharer = 1,
            Accompanying = 2,
        }

        [JsonProperty("guestId")]
        public int? GuestId { get; set; }

        [JsonProperty("guest")]
        public Guest Guest { get; set; }

        [JsonProperty("arrivalDate")]
        public string ArrivalDate { get; set; }

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [JsonProperty("guestType")]
        public GuestTypes GuestType { get; set; }
    }
}