using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue function space.
    /// </summary>
    public class Package : ISerializable
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

        [JsonProperty("minPax")]
        public int MinPax
        {
            get; set;
        }

        [JsonProperty("price")]
        public string Price
        {
            get; set;
        }

        [JsonProperty("priceMethod")]
        public string PriceMethod
        {
            get; set;
        }

        [JsonProperty("smallDescription")]
        public string SmallDescription
        {
            get; set;
        }

        [JsonProperty("largeDescription")]
        public string LargeDescription
        {
            get; set;
        }
    }
}