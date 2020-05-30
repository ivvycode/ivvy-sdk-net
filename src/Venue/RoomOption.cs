using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Venue
{
    /// <summary>
    /// An iVvy venue accommodation room option.
    /// </summary>
    public class RoomOption : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("price")]
        public float? Price
        {
            get; set;
        }

        [JsonProperty("priceExcludedTaxIds")]
        public int[] PriceExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("cost")]
        public float? Cost
        {
            get; set;
        }

        [JsonProperty("costExcludedTaxIds")]
        public int[] CostExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("costcenterId")]
        public int? CostCenterId
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