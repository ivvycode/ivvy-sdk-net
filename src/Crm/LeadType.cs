using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM lead type.
    /// </summary>
    public class LeadType : ISerializable
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id
        {
            get; set;
        }

        [JsonProperty("type")]
        public string Type
        {
            get; set;
        }
    }
}