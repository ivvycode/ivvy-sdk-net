using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// A booking tax detail object.
    /// </summary>
    public class TaxDetail : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("tax")]
        public string Tax
        {
            get; set;
        }
    }
}