using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM lead stage.
    /// </summary>
    public class LeadStage : ISerializable
    {

        public enum ApplyToOptions
        {
            Opportunity = 1,
            Lead = 2
        };

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("applyTo")]
        public ApplyToOptions? ApplyTo
        {
            get; set;
        }

        [JsonProperty("reasons")]
        public StageReason[] Reasons
        {
            get; set;
        }
    }
}