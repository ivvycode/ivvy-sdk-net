using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// A daily breakdown of tax applied to a booking item.
    /// </summary>
    public class DayTaxDetail : ISerializable
    {
        [JsonProperty("date")]
        public DateTime? Date
        {
            get; set;
        }

        [JsonProperty("taxDetails")]
        public TaxDetail[] TaxDetails
        {
            get;set;
        }
    }
}
