using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A container for the attributes common to all Packageable items
    /// </summary>
    public abstract class PackageableBookingItem : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("startDate")]
        public DateTime? StartDate
        {
            get; set;
        }

        [JsonProperty("endDate")]
        public DateTime? EndDate
        {
            get; set;
        }

        [JsonProperty("startTime")]
        public DateTime? StartTime
        {
            get; set;
        }

        [JsonProperty("endTime")]
        public DateTime? EndTime
        {
            get; set;
        }

        [JsonProperty("cost")]
        public double? Cost
        {
            get; set;
        }

        [JsonProperty("discount")]
        public double Discount
        {
            get; set;
        }

        [JsonProperty("surcharge")]
        public double Surcharge
        {
            get; set;
        }

        [JsonProperty("excludedTaxIds")]
        public int[] ExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("totalAmount")]
        public double TotalAmount
        {
            get; set;
        }

        [JsonProperty("totalDiscount")]
        public double TotalDiscount
        {
            get; set;
        }

        [JsonProperty("totalSurcharge")]
        public double TotalSurcharge
        {
            get; set;
        }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount
        {
            get; set;
        }

        [JsonProperty("includeInPackage")]
        public bool IncludeInPackage
        {
            get; set;
        }

        [JsonProperty("bookingPackageId")]
        public int? BookingPackageId
        {
            get; set;
        }

        [JsonProperty("costCenterId")]
        public int CostCenterId
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

        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
        {
            get; set;
        }

        [JsonProperty("totalAttendees")]
        public int TotalAttendees
        {
            get; set;
        }
    }
}