using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.CRM
{
    /// <summary>
    /// An iVvy Lead types.
    /// </summary>
    public class LeadTypes : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}