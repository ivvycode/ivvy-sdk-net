using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Beverage Package details on an iVvy venue booking.
    /// </summary>
    public class BeveragePackage : ISerializable
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

        [JsonProperty("smallDescription")]
        public decimal SmallDescription
        {
            get; set;
        }

        [JsonProperty("marketplaceName")]
        public decimal MarketplaceName
        {
            get; set;
        }

        [JsonProperty("taxDetails")]
        public Tax[] TaxDetails
        {
            get; set;
        }
    }
}