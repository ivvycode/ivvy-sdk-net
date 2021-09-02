using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// Base class for ivvy venue items such as menus and beverage packages
    /// </summary>
    public abstract class VenueItem : ISerializable
    {
        public enum MarketplaceCategoryValues
        {
            Breakfast = 1,
            MorningBreak = 2,
            Lunch = 3,
            AfternoonBreak = 4,
            Dinner = 5,
            Cocktail = 6
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

        [JsonProperty("smallDescription")]
        public string SmallDescription
        {
            get; set;
        }

        [JsonProperty("marketplaceName")]
        public string MarketplaceName
        {
            get; set;
        }

        [JsonProperty("marketplaceCategories")]
        public MarketplaceCategoryValues[] MarketplaceCategories
        {
            get; set;
        }
    }
}