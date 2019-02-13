using Newtonsoft.Json;

namespace Ivvy.Batch
{
    public class RestartResponse
    {
        [JsonProperty("restarted")]
        public bool Restarted { get; set; }
    }
}