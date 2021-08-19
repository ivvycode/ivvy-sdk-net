using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM lead channel.
    /// </summary>
    public class LeadChannel : ISerializable
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
    }
}