using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue function space.
    /// </summary>
    public class FunctionSpace : ISerializable
    {
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

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("minPax")]
        public int? MinPax
        {
            get; set;
        }

        [JsonProperty("maxPax")]
        public int? MaxPax
        {
            get; set;
        }
    }
}