using Ivvy.API.Common;
using Ivvy.API.Json.Converters;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A single session on an iVvy venue booking as returned from GetBookingSessionList.
    /// </summary>
    public class DetailedSession : Session
    {
        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("bookingId")]
        public int BookingId
        {
            get; set;
        }

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("contact")]
        public Contact.Contact Contact
        {
            get; set;
        }

        [JsonProperty("sessionTypeId")]
        public int? SessionTypeId
        {
            get; set;
        }

        [JsonProperty("sessionType")]
        public SimpleIdNameType SessionType
        {
            get; set;
        }

        [JsonProperty("space")]
        public SimpleIdNameType Space
        {
            get; set;
        }

        [JsonProperty("tariffId")]
        public int TariffId
        {
            get; set;
        }

        [JsonProperty("costAfterAdjustment")]
        public double CostAfterAdjustment
        {
            get; set;
        }

        [JsonProperty("costDiscount")]
        public double CostDiscount
        {
            get; set;
        }

        [JsonProperty("costSurcharge")]
        public double CostSurcharge
        {
            get; set;
        }

        [JsonProperty("amount")]
        public override double TotalAmount
        {
            get; set;
        }

        [JsonProperty("sfExcludedTaxIds")]
        [JsonConverter(typeof(IntArrayOrObjectConverter))]
        public int[] SFExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("setupTime")]
        public int SetupTime
        {
            get; set;
        }

        [JsonProperty("setdownTime")]
        public int SetdownTime
        {
            get; set;
        }

        [JsonProperty("canBeMoved")]
        public bool CanBeMoved
        {
            get; set;
        }

        [JsonProperty("minAttendeesGuaranteed")]
        public int? MinAttendeesGuaranteed
        {
            get; set;
        }

        [JsonProperty("agreedAttendees")]
        public int? AgreedAttendees
        {
            get; set;
        }

        [JsonProperty("expectedAttendees")]
        public int? ExpectedAttendees
        {
            get; set;
        }

        [JsonProperty("guaranteedAttendees")]
        public override int TotalAttendees
        {
            get; set;
        }

        [JsonProperty("setAttendees")]
        public int? SetAttendes
        {
            get; set;
        }

        [JsonProperty("actualAttendees")]
        public int? ActualAttendees
        {
            get; set;
        }

        [JsonProperty("signage")]
        public string Signage
        {
            get; set;
        }

        [JsonProperty("isSignageVisible")]
        public bool IsSignageVisible
        {
            get; set;
        }

        [JsonProperty("RoomHireType")]
        public int? RoomHireType
        {
            get; set;
        }

        [JsonProperty("overridePax")]
        public bool OverridePax
        {
            get; set;
        }

        [JsonProperty("minSpendRemainder")]
        public double MinSpendRemainder
        {
            get; set;
        }
    }
}