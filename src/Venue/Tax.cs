using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Venue
{
    /// <summary>
    /// An iVvy venue tax.
    /// </summary>
    public class Tax : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}