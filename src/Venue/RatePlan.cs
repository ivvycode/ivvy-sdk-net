using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue rate plan.
    /// </summary>
    public class RatePlan : ISerializable
    {
        public enum CloseOutStatusOptions
        {
            Open = 1,
            Closed = 2
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("code")]
        public string Code
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }
    }
}