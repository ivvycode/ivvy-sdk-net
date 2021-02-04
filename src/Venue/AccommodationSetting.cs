using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue's accommodation settings.
    /// </summary>
    public class AccommodationSetting
    {
        [JsonProperty("enableMultiOccupancy")]
        public bool EnableMultiOccupancy
        {
            get; set;
        }
    }
}
