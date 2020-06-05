using Newtonsoft.Json;

namespace Ivvy.API.Venue.ARI
{
    /// <summary>
    /// The dynamic inventory count of a single venue room.
    /// </summary>
    public class RoomCount
    {
        [JsonProperty("roomId")]
        public int RoomId
        {
            get; set;
        }

        [JsonProperty("startDate")]
        public string StartDate
        {
            get; set;
        }

        [JsonProperty("endDate")]
        public string EndDate
        {
            get; set;
        }

        [JsonProperty("roomCount")]
        public int Count
        {
            get; set;
        }
    }
}