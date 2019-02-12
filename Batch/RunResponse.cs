using Newtonsoft.Json;

namespace Ivvy.Batch
{
    public class RunResponse
    {
        [JsonProperty("asyncId")]
        public string AsyncId { get; set; }
    }
}