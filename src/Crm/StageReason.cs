using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// Encapsulates the details of reason that is sent with lead stages
    /// </summary>
    public class StageReason
    {
        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("reason")]
        public string Reason
        {
            get; set;
        }
    }
}