using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a cost center commission in a venue booking.
    /// </summary>
    public class CostCentreCommission : ISerializable
    {
        [JsonProperty("costCenterId")]
        public int CostCenterId
        {
            get; set;
        }

        [Obsolete("This property has been deprecated. Use CostCenterId instead.")]
        public int CostCentreId
        {
            get => CostCenterId;
            set => CostCenterId = value;
        }

        [JsonProperty("commission")]
        public double Commission
        {
            get; set;
        }
    }
}