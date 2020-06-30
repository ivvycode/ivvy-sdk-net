using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// An accommodation room reservation on an iVvy venue booking.
    /// </summary>
    public class RoomReservation : ISerializable
    {
        public enum StatusOptions
        {
            NotConfirmed = 1,
            Confirmed = 2,
            Cancelled = 3,
            CheckedIn = 4,
            CheckedOut = 5,
        }

        public RoomReservation()
        {
            CanBeEdited = true;
        }

        [JsonProperty("id")]
        public int? Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("bookingId")]
        public int BookingId
        {
            get; set;
        }

        [JsonProperty("canBeEdited")]
        public bool CanBeEdited
        {
            get; set;
        }

        [JsonProperty("reference")]
        public string Reference
        {
            get; set;
        }

        [JsonProperty("mainGuestId")]
        public int? MainGuestId
        {
            get; set;
        }

        [JsonProperty("mainGuest")]
        public Guest MainGuest
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public StatusOptions? CurrentStatus
        {
            get; set;
        }

        [JsonProperty("cancelledDate")]
        public DateTime? CancelledDate
        {
            get; set;
        }

        [JsonProperty("isFromGroup")]
        public bool? IsFromGroup
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public float? TotalAmount
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

        [JsonProperty("rooms")]
        public RoomReservationRoom[] Rooms
        {
            get; set;
        }

        [JsonProperty("removeRooms")]
        public int[] RemoveRooms
        {
            get; set;
        }
    }
}