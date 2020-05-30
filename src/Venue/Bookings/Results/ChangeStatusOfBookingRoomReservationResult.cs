using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue.Bookings
{
    public class ChangeStatusOfBookingRoomReservationResult : ISerializable
    {
        public enum Errors {
            Unknown = 0,
            SameStatus = 1,
            InvalidTransition = 2,
            Unsupported = 3,
            CanBeEditedFlag = 4,
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