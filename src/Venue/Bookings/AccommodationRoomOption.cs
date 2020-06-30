using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A room option that has been added to a group accommodation block on an iVvy venue booking.
    /// </summary>
    public class AccommodationRoomOption : ISerializable
    {
        [JsonProperty("bookingDate")]
        public string BookingDate
        {
            get; set;
        }

        [JsonProperty("roomOptionId")]
        public int RoomOptionId
        {
            get; set;
        }

        [JsonProperty("numRooms")]
        public int NumRooms
        {
            get; set;
        }

        [JsonProperty("numOptionsPerRoom")]
        public int NumOptionsPerRoom
        {
            get; set;
        }

        [JsonProperty("price")]
        public float Price
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public int[] ExcludedTaxIds
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

        [JsonProperty("costcenterId")]
        public int? CostCenterId
        {
            get; set;
        }

        [JsonProperty("numPayableByGuest")]
        public int NumPayableByGuest
        {
            get; set;
        }
    }
}