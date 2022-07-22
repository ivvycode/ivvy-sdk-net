using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// iVvy venue beverage package.
    /// </summary>
    public class BeveragePackage : VenueItem
    {
        public enum PriceMethods
        {
            HourlyRate = 99,
            PerPerson = 100,
            FixedRate = 102,
            TotalOfItems = 103
        }

        [JsonProperty("minPax")]
        public int? MinPax
        {
            get; set;
        }

        [JsonProperty("maxPax")]
        public int? MaxPax
        {
            get; set;
        }

        [JsonProperty("price")]
        public double? Price
        {
            get; set;
        }

        [JsonProperty("priceMethod")]
        public PriceMethods PriceMethod
        {
            get; set;
        }
    }
}