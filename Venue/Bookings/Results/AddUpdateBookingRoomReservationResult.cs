using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue.Bookings
{
    public class AddUpdateBookingRoomReservationResult : ISerializable
    {
        /// <summary>
        /// Indicates success or failure of the api action.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The unique id of the reservation that was added/updated.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The unique reference of the reservation that was added/updated.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Some details of the main guest on the reservation.
        /// </summary>
        [JsonProperty("mainGuest")]
        public Guest MainGuest { get; set; }

        /// <summary>
        /// Some details of the reserved rooms that were added/updated.
        /// </summary>
        [JsonProperty("rooms")]
        public Room[] Rooms { get; set; }

        public class Room : ISerializable
        {
            /// <summary>
            /// The unique id of the reserved room.
            /// </summary>
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Some details of the guest on the reserved room.
            /// </summary>
            [JsonProperty("guest")]
            public Guest Guest { get; set; }
        }

        public class Guest : ISerializable
        {
            /// <summary>
            /// The unique id of the guest.
            /// </summary>
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// The unique id of the contact details of the guest.
            /// </summary>
            [JsonProperty("contactId")]
            public int ContactId { get; set; }
        }
    }
}