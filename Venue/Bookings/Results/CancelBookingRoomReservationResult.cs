using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue.Bookings
{
    public class CancelBookingRoomReservationResult : ISerializable
    {
        public enum Errors {
            Unknown = 0,
            AlreadyCancelled = 1,
            InvalidStatus = 2,
            UnknownChannelError1 = 3,
            UnknownChannelError2 = 4,
            IndividualRoomsError = 5,
            BadStatus = 6,
            CanBeEditedFlag = 7,
        }

        /// <summary>
        /// Indicates success or failure of the api action.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The error code on failure.
        /// </summary>
        [JsonProperty("errorType")]
        public Errors? ErrorType { get; set; }
    }
}