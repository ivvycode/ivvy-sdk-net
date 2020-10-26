using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// OpportunityAllocation user details
    /// </summary>
    public class OpportunityAllocationUserDetail : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get; set;
        }
    }
}