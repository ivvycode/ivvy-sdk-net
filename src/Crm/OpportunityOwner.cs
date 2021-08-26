using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    public class OpportunityOwner
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
        {
            get; set;
        }

        [JsonProperty("firstName")]
        public string FirstName
        {
            get; set;
        }

        [JsonProperty("lastName")]
        public string LastName
        {
            get; set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get; set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get; set;
        }
    }
}
