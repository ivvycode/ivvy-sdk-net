using System;
using Ivvy.API.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Ivvy.API.Venue.Bookings
{
    /// <summary>
    /// Details of a packageable booking item which can also participate in a session.
    /// </summary>
    public abstract class SessionablePackageableBookingItem : PackageableBookingItem
    {
        [JsonProperty("SessionId")]
        public int SessionId
        {
            get; set;
        }
    }
}