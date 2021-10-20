using System;
using Ivvy.API.Json;
using Ivvy.API.Json.Converters;
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
        [JsonConverter(typeof(IsoDateOnlyConverter))]
        public DateTime? StartDate
        {
            get; set;
        }

        [JsonProperty("endDate")]
        [JsonConverter(typeof(IsoDateOnlyConverter))]
        public DateTime? EndDate
        {
            get; set;
        }

        [JsonProperty("startTime")]
        [JsonConverter(typeof(IsoTimeOnlyConverter))]
        public DateTime? StartTime
        {
            get; set;
        }

        [JsonProperty("endTime")]
        [JsonConverter(typeof(IsoTimeOnlyConverter))]
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
        public virtual double TotalAmount
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
        public virtual int TotalAttendees
        {
            get; set;
        }
    }
}