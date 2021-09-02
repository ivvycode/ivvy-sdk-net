using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a resource on a venue booking session.
    /// </summary>
    public class Resource : SessionablePackageableBookingItem
    {
        [JsonProperty("quantity")]
        public int Quantity
        {
            get; set;
        }
    }
}