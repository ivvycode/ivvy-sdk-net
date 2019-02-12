using Newtonsoft.Json;

namespace Ivvy.Batch
{
    public class Job
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("params")]
        public dynamic RequestData { get; set; }
    }
}