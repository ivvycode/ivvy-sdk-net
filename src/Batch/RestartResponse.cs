using Newtonsoft.Json;

namespace Ivvy.API.Batch
{
    public class RestartResponse
    {
        [JsonProperty("restarted")]
        public bool Restarted
        {
            get; set;
        }
    }
}