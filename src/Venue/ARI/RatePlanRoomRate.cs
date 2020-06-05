using Newtonsoft.Json;

namespace Ivvy.API.Venue.ARI
{
    /// <summary>
    /// The dynamic rate of a room in a rate plan.
    /// </summary>
    public class RatePlanRoomRate
    {
        [JsonProperty("barId")]
        public int RatePlanId
        {
            get; set;
        }

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

        [JsonProperty("cost")]
        public int Cost
        {
            get; set;
        }
    }
}