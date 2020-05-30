using Newtonsoft.Json;

namespace Ivvy.API.Batch
{
    public class ProgressResponse
    {
        [JsonProperty("progress")]
        public float Progress
        {
            get; set;
        }
    }
}