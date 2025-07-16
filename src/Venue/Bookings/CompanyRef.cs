using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    public class CompanyRef : ISerializable
    {
        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("businessName")]
        public string BusinessName
        {
            get; set;
        }
    }
}