using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of an additional item on a venue booking.
    /// </summary>
    public class AdditionalItem : ISerializable
    {
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("quantity")]
        public double Quantity
        {
            get; set;
        }

        [JsonProperty("totalCost")]
        public double TotalCost
        {
            get; set;
        }

        [JsonProperty("totalCostDiscount")]
        public double TotalCostDiscount
        {
            get; set;
        }

        [JsonProperty("totalCostSurcharge")]
        public double TotalCostSurcharge
        {
            get; set;
        }

        [JsonProperty("totalCostExcludedTaxIds")]
        public int[] TotalCostExcludedTaxIds
        {
            get; set;
        }

        [JsonProperty("actualCost")]
        public double ActualCost
        {
            get; set;
        }

        [JsonProperty("actualCostExcludedTaxIds")]
        public int[] ActualCostExcludedTaxIds
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

        [JsonProperty("costCenterId")]
        public int CostCenterId
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

        [JsonProperty("startDateTime")]
        public DateTime? StartDateTime
        {
            get; set;
        }

        [JsonProperty("endDateTime")]
        public DateTime? EndDateTime
        {
            get; set;
        }


        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
        {
            get; set;
        }

        [JsonProperty("dayTaxDetails")]
        public DayTaxDetail[] DayTaxDetails
        {
            get; set;
        }
    }
}