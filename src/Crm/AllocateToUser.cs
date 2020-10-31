using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// Details of the user to which an opportunity should be allocated.
    /// </summary>
    public class AllocateToUser
    {
        [JsonProperty("id")]
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
    }
}