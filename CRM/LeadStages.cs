using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.CRM
{
    /// <summary>
    /// An iVvy Lead stages.
    /// </summary>
    public class LeadStages : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}