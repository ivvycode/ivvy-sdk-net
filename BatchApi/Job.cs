using Newtonsoft.Json;

namespace Ivvy
{
    public class Job<T>
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("params")]
        public T Params { get; set; }
    }
}
