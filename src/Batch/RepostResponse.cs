using Newtonsoft.Json;

namespace Ivvy.Batch
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