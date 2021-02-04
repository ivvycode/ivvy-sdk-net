using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// An iVvy venue.
    /// </summary>
    public class Venue : ISerializable
    {
        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("hashId")]
        public string HashId
        {
            get; set;
        }

        [JsonProperty("businessName")]
        public string BusinessName
        {
            get; set;
        }

        [JsonProperty("businessNumber")]
        public string BusinessNumber
        {
            get; set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get; set;
        }

        [JsonProperty("fax")]
        public string Fax
        {
            get; set;
        }

        [JsonProperty("websiteAddress")]
        public string WebsiteAddress
        {
            get; set;
        }

        [JsonProperty("emailAddress")]
        public string EmailAddress
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("checkinTime")]
        public string CheckinTime
        {
            get; set;
        }

        [JsonProperty("checkoutTime")]
        public string CheckoutTime
        {
            get; set;
        }

        [JsonProperty("childAge")]
        public int? ChildAge
        {
            get; set;
        }

        [JsonProperty("infantAge")]
        public int? InfantAge
        {
            get; set;
        }

        [JsonProperty("currencyCode")]
        public string CurrencyCode
        {
            get; set;
        }

        [JsonProperty("localeCode")]
        public string LocaleCode
        {
            get; set;
        }

        [JsonProperty("timezone")]
        public string TimeZoneId
        {
            get; set;
        }

        [JsonProperty("hasSpaces")]
        public bool HasSpaces
        {
            get; set;
        }

        [JsonProperty("hasAccommodation")]
        public bool HasAccommodation
        {
            get; set;
        }

        [JsonProperty("numMeetingRooms")]
        public int? NumMeetingRooms
        {
            get; set;
        }

        [JsonProperty("numAccommodationRooms")]
        public int? NumAccommodationRooms
        {
            get; set;
        }

        [JsonProperty("maxSpaceArea")]
        public float? MaxSpaceArea
        {
            get; set;
        }

        [JsonProperty("totalSpaceArea")]
        public float? TotalSpaceArea
        {
            get; set;
        }

        [JsonProperty("longitude")]
        public string Longitude
        {
            get; set;
        }

        [JsonProperty("latitude")]
        public string Latitude
        {
            get; set;
        }

        [JsonProperty("isTaxExclusive")]
        public bool IsTaxExclusive
        {
            get; set;
        }

        [JsonProperty("functionSpaces")]
        public FunctionSpace[] FunctionSpaces
        {
            get; set;
        }

        [JsonProperty("packages")]
        public Package[] Packages
        {
            get; set;
        }

        [JsonProperty("accommodationSetting")]

        public AccommodationSetting AccommodationSetting
        {
            get; set;
        }
    }
}