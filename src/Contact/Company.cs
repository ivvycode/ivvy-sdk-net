using System;
using System.Collections.Generic;
using System.Text;
using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Contact
{
    public class Company
    {
        [JsonProperty("id")]
        public string id { get; set; }
        public string businessName { get; set; }
        public string tradingName { get; set; }
        public string businessNumber { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string website { get; set; }
        public Address address { get; set; }
    }

    public class Address : ISerializable
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public string line4 { get; set; }
        public string city { get; set; }
        public string stateCode { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }
}
