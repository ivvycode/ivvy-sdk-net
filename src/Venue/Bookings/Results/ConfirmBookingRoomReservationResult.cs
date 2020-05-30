using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class ConfirmBookingRoomReservationResult : ISerializable
    {
        public enum Errors
        {
            Unknown = 0,
            AlreadyConfirmed = 1,
            IsCancelled = 2,
            NoRooms = 3,
            GroupCannotConfirmAvailability = 4,
            GroupNotEnoughRooms = 5,
            UnknownChannelError1 = 6,
            IndividualRoomsError = 7,
            UnknownChannelError2 = 8,
            CanBeEditedFlag = 9,
        }

        /// <summary>
        /// Indicates success or failure of the api action.
        /// </summary>
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }

        /// <summary>
        /// The error code on failure.
        /// </summary>
        [JsonProperty("errorType")]
        public Errors? ErrorType
        {
            get; set;
        }
    }
}