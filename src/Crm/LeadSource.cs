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
        public int Id
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
        public float Cost
        {
            get; set;
        }

        [JsonProperty("isReferral")]
        public bool IsReferral
        {
            get; set;
        }

        [JsonProperty("defaultType")]
        public int? DefaultType
        {
            get; set;
        }
    }
}