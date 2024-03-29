using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a menu on a venue booking session.
    /// </summary>
    public class Menu : SessionablePackageableBookingItem
    {

        [JsonProperty("menuVenueId")]
        public int MenuVenueId
        {
            get; set;
        }

        [JsonProperty("menuId")]
        public int MenuId
        {
            get; set;
        }

        [JsonProperty("menuTypeCategory")]
        public int MenuTypeCategory
        {
            get; set;
        }

        public string GetMenuCategory()
        {
            var menuCategory = "";
            switch (MenuTypeCategory)
            {
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