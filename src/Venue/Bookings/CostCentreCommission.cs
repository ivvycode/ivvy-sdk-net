using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a cost centre commission in a venue booking.
    /// </summary>
    public class CostCentreCommission : ISerializable
    {
        [JsonProperty("costCentreId")]
        public int CostCentreId
        {
            get; set;
        }

        [JsonProperty("commission")]
        public double Commission
        {
            get; set;
        }
    }
}