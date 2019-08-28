using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue
{
    /// <summary>
    /// An iVvy venue function space.
    /// </summary>
    public class FunctionSpace : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
