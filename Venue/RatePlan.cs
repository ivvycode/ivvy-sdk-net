using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue
{
    /// <summary>
    /// An iVvy venue rate plan.
    /// </summary>
    public class RatePlan : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}