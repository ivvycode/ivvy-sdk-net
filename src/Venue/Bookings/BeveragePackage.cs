using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a beverage package on a venue booking session.
    /// </summary>
    public class BeveragePackage : SessionablePackageableBookingItem
    {

        [JsonProperty("beverageVenueId")]
        public int BeverageVenueId
        {
            get; set;
        }

        [JsonProperty("beverageId")]
        public int BeverageId
        {
            get; set;
        }

        [JsonProperty("smallDescription")]
        public string SmallDescription
        {
            get; set;
        }

        [JsonProperty("marketplaceName")]
        public string MarketplaceName
        {
            get; set;
        }
    }
}