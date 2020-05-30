using Newtonsoft.Json;

namespace Ivvy.API.Batch
{
    public class RepostResponse
    {
        [JsonProperty("reposted")]
        public bool Reposted
        {
            get; set;
        }
    }
}