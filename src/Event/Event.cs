using Ivvy.API.Json;
using Newtonsoft.Json;
using System;

namespace Ivvy.API.Event
{
    /// <summary>
    /// An iVvy event.
    /// </summary>
    public class Event : ISerializable
    {
        public enum EventTypes
        {
            Other = 0,
            Party = 1,
            Festival = 2,
            GolfDay = 3,
            Wedding = 4,
            Meeting = 5,
            Seminar = 6,
            Conference = 7,
            Exhibition = 8,
            Roadshow = 9,
            Simple = 10,
            Party18or21 = 11
        }

        public enum StatusTypes
        {
            Draft = 0,
            Closed = 1,
            Launched = 3
        }

        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("code")]
        public string Code
        {
            get; set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get; set;
        }

        [JsonProperty("eventType")]
        public EventTypes EventType
        {
            get; set;
        }

        [JsonProperty("capacity")]
        public int Capacity
        {
            get; set;
        }

        [JsonProperty("numRegistered")]
        public int NumRegistered
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public StatusTypes CurrentStatus
        {
            get; set;
        }

        [JsonProperty("domainName")]
        public string DomainName
        {
            get; set;
        }

        [JsonProperty("timezone")]
        public string TimeZoneId
        {
            get; set;
        }

        [JsonProperty("startDateTime")]
        public DateTime StartDateTime
        {
            get; set;
        }

        [JsonProperty("endDateTime")]
        public DateTime EndDateTime
        {
            get; set;
        }

        [JsonProperty("contactName")]
        public string ContactName
        {
            get; set;
        }

        [JsonProperty("contactEmail")]
        public string ContactEmail
        {
            get; set;
        }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate
        {
            get; set;
        }
    }
}