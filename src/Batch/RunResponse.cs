using Newtonsoft.Json;

namespace Ivvy.API.Batch
{
    public class RunResponse
    {
        [JsonProperty("asyncId")]
        public string AsyncId
        {
            get; set;
        }
    }
}