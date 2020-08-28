using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    public class CostCenter
    {
        public enum DefaultTypes
        {
            Other = 1,
            VenueFood = 2,
            VenueBeverage = 3,
            VenueAudioVisual = 4,
            VenueRoomHire = 5,
            VenueAccommodation = 6,
        }

        [JsonProperty("id")]
        public int? Id
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("code")]
        public string Code
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("defaultType")]
        public DefaultTypes? DefaultType
        {
            get; set;
        }

        [JsonProperty("parentId")]
        public int? ParentId
        {
            get; set;
        }
    }
}
