using Newtonsoft.Json;

namespace Ivvy.API.Common
{
    public class SimpleIdNameType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }
    }
}
