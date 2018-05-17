using Newtonsoft.Json;

namespace Ivvy.Invoice
{
    public class Address
    {
        [JsonProperty("line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("line3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("line4")]
        public string AddressLine4 { get; set; }

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
