using Newtonsoft.Json;

namespace Ivvy.Venue
{
    public class FunctionSpace
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
