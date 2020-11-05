using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM lead source.
    /// </summary>
    public class LeadSource : ISerializable
    {
        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("cost")]
        public string Cost
        {
            get; set;
        }

        [JsonProperty("isReferral")]
        public string IsReferral
        {
            get; set;
        }

        [JsonProperty("defaultType")]
        public string DefaultType
        {
            get; set;
        }
    }
}