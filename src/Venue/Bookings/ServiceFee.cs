using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A description of service fee applied to a booking item.
    /// </summary>
    public class ServiceFee
    {
        public enum RefTypes
        {
            Room = 1,
            RoomExtra = 2,
            Package = 3,
            Session = 4,
            Menu = 5,
            BeveragePackage = 6,
            Product = 7,
            Resource = 8,
            AdditionalItem = 9,
            ServiceFee = 10,
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("refType")]
        public RefTypes RefType
        {
            get; set;
        }

        [JsonProperty("refId")]
        public int RefId
        {
            get; set;
        }

        [JsonProperty("ref2Id")]
        public int Ref2Id
        {
            get; set;
        }

        [JsonProperty("ref3Id")]
        public int Ref3Id
        {
            get; set;
        }

        [JsonProperty("refDate")]
        public string RefDate
        {
            get; set;
        }

        [JsonProperty("refCostcenterId")]
        public int RefCostcenterId
        {
            get; set;
        }

        [JsonProperty("amount")]
        public double Amount
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public List<object> ExcludedTaxIds
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

        [JsonProperty("totalAmount")]
        public double TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount
        {
            get; set;
        }

        [JsonProperty("taxDetails")]
        public List<TaxDetail> TaxDetails
        {
            get; set;
        }
    }
}
