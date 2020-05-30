using Newtonsoft.Json;

namespace Ivvy.Batch
{
    public class ProgressResponse
    {
        [JsonProperty("progress")]
        public float Progress { get; set; }
    }
}