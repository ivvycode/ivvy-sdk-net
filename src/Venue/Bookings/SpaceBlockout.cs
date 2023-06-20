using System;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class SpaceBlockout
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("spaceId")]
        public int SpaceId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("startDate")]
        public DateTime? StartDate
        {
            get; set;
        }

        [JsonProperty("startTime")]
        public DateTime? StartTime
        {
            get; set;
        }

        [JsonProperty("endDate")]
        public DateTime? EndDate
        {
            get; set;
        }

        [JsonProperty("endTime")]
        public DateTime? EndTime
        {
            get; set;
        }

        [JsonProperty("bookedById")]
        public int BookedById
        {
            get; set;
        }
    }
}
