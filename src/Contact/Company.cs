using System;
using Ivvy.API.Common;
using Newtonsoft.Json;

namespace Ivvy.API.Contact
{
    public class Company : CompanyReference
    {
        [JsonProperty("tradingName")]
        public string TradingName
        {
            get; set;
        }

        [JsonProperty("businessNumber")]
        public string BusinessNumber
        {
            get; set;
        }

        [JsonProperty("primaryContact")]
        public Contact PrimaryContact
        {
            get; set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get; set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get; set;
        }

        [JsonProperty("otherPhone")]
        public string OtherPhone
        {
            get; set;
        }

        [JsonProperty("fax")]
        public string Fax
        {
            get; set;
        }

        [JsonProperty("website")]
        public string Website
        {
            get; set;
        }

        [JsonProperty("address")]
        public Address Address
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime? ModifiedDate
        {
            get; set;
        }

        [JsonProperty("externalId")]
        public string ExternalId
        {
            get; set;
        }

        [JsonProperty("updateIfExists")]
        public bool UpdateIfExists
        {
            get; set;
        }

        [JsonProperty("isAgent")]
        public int IsAgent
        {
            get; set;
        }
    }
}