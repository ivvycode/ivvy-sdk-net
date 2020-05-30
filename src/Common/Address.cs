using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Common
{
    public class Address : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("line4")]
        public string Line4 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }
}