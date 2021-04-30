using System;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy event type.
    /// </summary>
    public class EventType
    {
        public enum MarketplaceEventTypeOptions
        {
            Other = 1,
            Christmas = 2,
            Cocktail = 3,
            Conference = 4,
            CorporateFunction = 5,
            Dinner = 6,
            Exhibition = 7,
            Meeting = 8,
            Party = 9,
            Wedding = 10,
            Event = 11,
            Breakfast = 13,
            Lunch = 14
        }

        public enum ContactTypeOptions
        {
            CompanyAndContact = 0,
            Company = 1,
            Contact = 2
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

        [JsonProperty("description")]
        public object Description
        {
            get; set;
        }

        [JsonProperty("marketplaceEventType")]
        public MarketplaceEventTypeOptions MarketplaceEventType
        {
            get; set;
        }

        [JsonProperty("contactType")]
        public ContactTypeOptions ContactType
        {
            get; set;
        }

        [JsonProperty("isViewable")]
        public bool IsViewable
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public DateTime? CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime? ModifiedDate
        {
            get; set;
        }
    }
}
