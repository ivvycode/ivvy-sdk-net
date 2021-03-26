using System;
using Newtonsoft.Json;

namespace Ivvy.API.Venue
{
    /// <summary>
    /// Object that can be used to update a status of booking.
    /// </summary>
    public class ChangeBookingStatusRequest
    {
        public enum MarketplaceStageReasonTypeOptions
        {
            AccommodationUnavailable = 1,
            AccommodationCapacityTooSmall = 2,
            ConferenceOrEventSpaceUnavailable = 3,
            ConferenceOrEventSpaceCapacityTooSmall = 4,
            ConferenceOrEventSpaceCapacityTooBig = 5,
            FacilitiesNotSuitable = 6,
            NoReasonGiven = 7
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public Booking.StatusOptions CurrentStatus
        {
            get; set;
        }

        [JsonProperty("changedByUserId")]
        public int? ChangedByUserId
        {
            get; set;
        }

        [JsonProperty("cancelStageId")]
        public int? CancelStageId
        {
            get; set;
        }

        [JsonProperty("cancelReasonId")]
        public int? CancelReasonId
        {
            get; set;
        }

        [JsonProperty("cancelLostToCompetition")]
        public string CancelLostToCompetition
        {
            get; set;
        }

        [JsonProperty("cancelClosedDate")]
        public DateTime? CancelClosedDate
        {
            get; set;
        }

        [JsonProperty("convertedStageId")]
        public int? ConvertedStageId
        {
            get; set;
        }

        [JsonProperty("convertedStageReasonId")]
        public int? ConvertedStageReasonId
        {
            get; set;
        }

        [JsonProperty("convertedClosedDate")]
        public DateTime? ConvertedClosedDate
        {
            get; set;
        }

        [JsonProperty("marketplaceStageReasonType")]
        public MarketplaceStageReasonTypeOptions? MarketplaceStageReasonType
        {
            get; set;
        }
    }
}
