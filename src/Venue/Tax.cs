using System.Collections.Generic;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue tax.
    /// </summary>
    public class Tax : ISerializable
    {
        public enum AmountTypeOptions
        {
            Percentage = 1,
            Amount = 2
        }

        public enum TypeOptions
        {
            Tax = 1,
            ServiceFees = 2
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

        [JsonProperty("amount")]
        public float? Amount
        {
            get; set;
        }

        [JsonProperty("amountType")]
        public AmountTypeOptions AmountType
        {
            get; set;
        }

        [JsonProperty("type")]
        public TypeOptions Type
        {
            get; set;
        }

        [JsonProperty("costcenterIds")]
        public int[] CostCenterIds
        {
            get; set;
        }
    }
}