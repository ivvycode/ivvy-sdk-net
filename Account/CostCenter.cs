using Newtonsoft.Json;

namespace Ivvy.Account
{
    public class CostCenter
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("defaultType")]
        public string DefaultType { get; set; }
    }
}
