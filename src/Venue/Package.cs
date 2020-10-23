using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// iVvy venue package.
    /// </summary>
    public class Package : ISerializable
    {
        public enum PriceMethods
        {
            PerPerson = 1,
            Fixed = 2
        }

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
        public decimal Price
        {
            get; set;
        }

        [JsonProperty("priceMethod")]
        public PriceMethods PriceMethod
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