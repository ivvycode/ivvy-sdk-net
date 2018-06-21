using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue
{
    /// <summary>
    /// An iVvy venue accommodation room.
    /// </summary>
    public class Room : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("numStandardAdults")]
        public int? NumStandardAdults { get; set; }

        [JsonProperty("numExtraAdults")]
        public int? NumExtraAdults { get; set; }

        [JsonProperty("extraAdultCost")]
        public float? ExtraAdultCost { get; set; }

        [JsonProperty("canSmoke")]
        public bool CanSmoke { get; set; }

        [JsonProperty("capacity")]
        public int? Capacity { get; set; }

        [JsonProperty("marketplaceName")]
        public string MarketplaceName { get; set; }
    }
}