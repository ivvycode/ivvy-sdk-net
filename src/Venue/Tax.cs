using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue tax.
    /// </summary>
    public class Tax : ISerializable
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

        // IVVY-TODO: AE-1786: I don't think this is in the iVvy api.
        [JsonProperty("rate")]
        public decimal Rate
        {
            get; set;
        }
    }
}