using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM opportunity.
    /// </summary>
    public class Opportunity
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
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

        [JsonProperty("stageId")]
        public int StageId
        {
            get; set;
        }

        [JsonProperty("typeId")]
        public int TypeId
        {
            get; set;
        }
    }
}