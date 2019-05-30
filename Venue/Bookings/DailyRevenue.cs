using Newtonsoft.Json;
using System;

namespace Ivvy.API.Venue.Bookings
{
    public class DailyRevenue
    {
        [JsonProperty("costcenterId")]
        public int CostCenterId { get; set; }

        [JsonProperty("revenueDate")]
        public DateTime RevenueDate { get; set; }

        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }
}
