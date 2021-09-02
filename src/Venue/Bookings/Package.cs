using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of an event template package on a venue booking.
    /// </summary>
    public class Package : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("bookingDate")]
        public string BookingDate
        {
            get;set;
        }

        [JsonProperty("numberAttendees")]
        public int NumberAttendees
        {
            get; set;
        }

        [JsonProperty("price")]
        public double Price
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate
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
            get;set;
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

        [JsonProperty("priceMethod")]
        public Ivvy.API.Venue.Package.PriceMethods PriceMethod
        {
            get; set;
        }

        [JsonProperty("costcenters")]
        public PackageCostCenter[] CostCenters
        {
            get; set;
        }
        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
        {
            get; set;
        }

        [JsonProperty("smallDescription")]
        public string SmallDescription
        {
            get; set;
        }

        [JsonProperty("packageId")]
        public int PackageId
        {
            get; set;
        }

        [JsonProperty("packageName")]
        public string PackageName
        {
            get; set;
        }
    }
}