using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// iVvy venue menu.
    /// </summary>
    public class Menu : VenueItem
    {
        public enum CostTypes
        {
            PerPerson = 1,
            FlatRate = 2,
            TotalOfItems = 3
        }

        [JsonProperty("menuTypeCategory")]
        public int MenuTypeCategory
        {
            get; set;
        }

        [JsonProperty("minimumPax")]
        public int? MinimumPax
        {
            get; set;
        }

        [JsonProperty("maximumPax")]
        public int? MaximumPax
        {
            get; set;
        }
        [JsonProperty("cost")]
        public int? Cost
        {
            get; set;
        }

        [JsonProperty("costType")]
        public CostTypes CostType
        {
            get; set;
        }

        [JsonProperty("costPerPerson")]
        public int? CostPerPerson
        {
            get; set;
        }

        public string GetMenuCategory()
        {
            var menuCategory = "";
            switch (MenuTypeCategory)
            {
                case 0:
                    menuCategory = "Unassigned";
                    break;
                case 1:
                    menuCategory = "Breakfast";
                    break;
                case 2:
                    menuCategory = "Lunch";
                    break;
                case 3:
                    menuCategory = "Dinner";
                    break;
                case 4:
                    menuCategory = "Coffee Break";
                    break;
                case 5:
                    menuCategory = "Reception";
                    break;
                case 6:
                    menuCategory = "Outside Catering";
                    break;
                default:
                    break;
            }

            return menuCategory;
        }

    }
}