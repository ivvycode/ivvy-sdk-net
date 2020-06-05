using Newtonsoft.Json;

namespace Ivvy.API.Venue.ARI
{
    /// <summary>
    /// The booking rules of a rate plan.
    /// </summary>
    public class RatePlanBookingRule
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

        [JsonProperty("closeOutStatus")]
        public RatePlan.CloseOutStatusOptions CloseOutStatus
        {
            get; set;
        }
    }
}