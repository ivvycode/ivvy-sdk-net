using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// An individual room on an accommodation room reservation on an iVvy venue booking.
    /// </summary>
    public class RoomReservationRoom : ISerializable
    {
        [JsonProperty("id")]
        public int? Id
        {
            get; set;
        }

        [JsonProperty("guestId")]
        public int? GuestId
        {
            get; set;
        }

        [JsonProperty("guest")]
        public Guest Guest
        {
            get; set;
        }

        [JsonProperty("additionalGuests")]
        public AdditionalGuest[] AdditionalGuests
        {
            get; set;
        }

        [JsonProperty("barId")]
        public int? RatePlanId
        {
            get; set;
        }

        [JsonProperty("roomId")]
        public int? RoomId
        {
            get; set;
        }

        [JsonProperty("groupId")]
        public int? GroupId
        {
            get; set;
        }

        [JsonProperty("numRooms")]
        public int? NumRooms
        {
            get; set;
        }

        [JsonProperty("arrivalDate")]
        public string ArrivalDate
        {
            get; set;
        }

        [JsonProperty("departureDate")]
        public string DepartureDate
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public float? TotalAmount
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public int[] ExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("numAdultGuests")]
        public int NumAdultGuests
        {
            get; set;
        }

        [JsonProperty("numChildGuests")]
        public int NumChildGuests
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public DateTime? CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime? ModifiedDate
        {
            get; set;
        }

        [JsonProperty("isCancelled")]
        public bool? IsCancelled
        {
            get; set;
        }

        [JsonProperty("cancelledDate")]
        public DateTime? CancelledDate
        {
            get; set;
        }

        [JsonProperty("dayRates")]
        public RoomReservationDayRate[] DayRates
        {
            get; set;
        }

        [JsonProperty("overrideBlockCapacity")]
        public bool OverrideBlockCapacity
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public RoomReservation.StatusOptions CurrentStatus
        {
            get; set;
        }

        [JsonProperty("externalReference")]
        public string ExternalReference
        {
            get; set;
        }

        [JsonProperty("occType")]
        public int? OccupancyType
        {
            get; set;
        }
    }
}