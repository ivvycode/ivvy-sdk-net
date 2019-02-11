using Newtonsoft.Json;

namespace Ivvy
{
    public class BatchResponse<T>
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("request")]
        public T Request { get; set; }

        [JsonProperty("response")]
        public Response  Response { get; set; }
    }
}
