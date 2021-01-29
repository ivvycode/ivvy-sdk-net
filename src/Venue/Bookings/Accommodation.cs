using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A group accommodation block on an iVvy venue booking.
    /// </summary>
    public class Accommodation : ISerializable
    {
        [JsonProperty("id")]
        public int? Id
        {
            get; set;
        }

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

        [JsonProperty("roomVenueId")]
        public int RoomVenueId
        {
            get; set;
        }

        [JsonProperty("barId")]
        public int? RatePlanId
        {
            get; set;
        }

        [JsonProperty("roomId")]
        public int? RoomId
        {
            get; set;
        }

        [JsonProperty("startDate")]
        public string StartDate
        {
            get; set;
        }

        [JsonProperty("endDate")]
        public string EndDate
        {
            get; set;
        }

        [JsonProperty("overrideCapacity")]
        public bool OverrideCapacity
        {
            get; set;
        }

        [JsonProperty("costcenterId")]
        public int? CostCenterId
        {
            get; set;
        }

        [JsonProperty("cutOffDate", NullValueHandling = NullValueHandling.Include)]
        public string CutOffDate
        {
            get; set;
        }

        [JsonProperty("dayRates")]
        public AccommodationDayRate[] DayRates
        {
            get; set;
        }

        [JsonProperty("dayRatesActual")]
        public AccommodationDayRate[] DayRatesActual
        {
            get; set;
        }

        [JsonProperty("dayRatesForecast")]
        public AccommodationDayRate[] DayRatesForecast
        {
            get; set;
        }

        [JsonProperty("dayRatesNet")]
        public AccommodationDayRate[] DayRatesNet
        {
            get; set;
        }

        [JsonProperty("dayRatesMultiOcc")]
        public AccommodationOccupancyDayRate[] DayRatesMultiOccupancy
        {
            get; set;
        }

        [JsonProperty("dayRatesActualMultiOcc")]
        public AccommodationOccupancyDayRate[] DayRatesActualMultiOccupancy
        {
            get; set;
        }

        [JsonProperty("dayRatesForecastMultiOcc")]
        public AccommodationOccupancyDayRate[] DayRatesForecastMultiOccupancy
        {
            get; set;
        }

        [JsonProperty("dayRatesNetMultiOcc")]
        public AccommodationOccupancyDayRate[] DayRatesNetMultiOccupancy
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public int[] ExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("roomOptions")]
        public AccommodationRoomOption[] RoomOptions
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public DateTime? CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime? ModifiedDate
        {
            get; set;
        }
    }
}