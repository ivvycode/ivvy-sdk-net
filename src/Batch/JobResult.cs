using Newtonsoft.Json;

namespace Ivvy.Batch
{
    public class JobResult
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("request")]
        public dynamic RequestData { get; set; }

        [JsonProperty("response")]
        public dynamic Response { get; set; }
    }
}