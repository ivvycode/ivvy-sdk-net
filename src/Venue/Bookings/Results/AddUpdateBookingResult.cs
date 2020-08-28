using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class AddUpdateBookingResult : ISerializable
    {
        /// <summary>
        /// This warning indicates the booking was added but the package could not be added to one or more days.
        /// </summary>
        public const string WARNING_PACKAGE_ERRORS = "packageErrors";

        /// <summary>
        /// This warning indicates the booking was added but one or more package sessions could not be added.
        /// </summary>
        public const string WARNING_PACKAGE_SESSION_ERRORS = "packageSessionErrors";

        /// <summary>
        /// Indicates success or failure of the api action.
        /// </summary>
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }

        /// <summary>
        /// The unique id of the booking that was added/updated.
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        /// <summary>
        /// Warning messages that can occur on success.
        /// </summary>
        public string[] Warnings
        {
            get; set;
        }
    }
}