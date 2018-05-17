using Ivvy.API.Helper;
using Ivvy.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.Event
{
    /// <summary>
    /// An iVvy event.
    /// </summary>
    public class Event : ISerializable
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("eventType")]
        public EnumHelper.EventTypes EventType { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("numRegistered")]
        public int NumRegistered { get; set; }

        [JsonProperty("currentStatus")]
        public EnumHelper.EventStatusTypes CurrentStatus { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("timezone")]
        public string TimeZoneId { get; set; }

        [JsonProperty("startDateTime")]
        public DateTime StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public DateTime EndDateTime { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }
    }
}