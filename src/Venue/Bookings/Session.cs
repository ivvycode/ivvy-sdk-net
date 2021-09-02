using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A single session on an iVvy venue booking.
    /// </summary>
    public class Session : PackageableBookingItem
    {

        [JsonProperty("spaceVenueId")]
        public int? SpaceVenueId
        {
            get; set;
        }

        [JsonProperty("spaceId")]
        public int? SpaceId
        {
            get; set;
        }

        [JsonProperty("spaceLayout")]
        public int? SpaceLayout
        {
            get; set;
        }

        [JsonProperty("customLayoutName")]
        public string CustomLayoutName
        {
            get; set;
        }

        [JsonProperty("beoNumbers")]
        public int[] BeoNumbers
        {
            get; set;
        }
    }
}