using Newtonsoft.Json;

namespace Ivvy
{
    public class Response
    {

        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }

        
    }
}
