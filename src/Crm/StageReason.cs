using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// The reason why an opportunity/lead is at a specific stage.
    /// </summary>
    public class StageReason
    {
        [JsonProperty("id")]
        public int Id
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