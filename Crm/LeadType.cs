using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Crm
{
    /// <summary>
    /// An iVvy CRM lead type.
    /// </summary>
    public class LeadType : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}