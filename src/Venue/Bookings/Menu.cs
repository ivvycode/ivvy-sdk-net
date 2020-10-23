using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a menu on a venue booking session.
    /// </summary>
    public class Menu : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("sessionId")]
        public int SessionId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("startDate")]
        public DateTime StartDate
        {
            get; set;
        }

        [JsonProperty("endDate")]
        public DateTime EndDate
        {
            get; set;
        }

        [JsonProperty("menuTypeCategory")]
        public int MenuTypeCategory
        {
            get; set;
        }

        [JsonProperty("includeInPackage")]
        public bool IncludeInPackage
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount
        {
            get; set;
        }

        [JsonProperty("cost")]
        public decimal Cost
        {
            get; set;
        }

        [JsonProperty("totalDiscount")]
        public decimal TotalDiscount
        {
            get; set;
        }

        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
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