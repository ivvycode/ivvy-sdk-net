using Ivvy.Common;
using Newtonsoft.Json;

namespace Ivvy.Contact
{
    public class Company
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        [JsonProperty("tradingName")]
        public string TradingName { get; set; }

        [JsonProperty("businessNumber")]
        public string BusinessNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
