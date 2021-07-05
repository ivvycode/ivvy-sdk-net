using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM event task.
    /// </summary>
    public class EventTask : ISerializable
    {
        public enum EventStatusOptions
        {
            NotStarted = 0,
            InProgress = 1,
            OnHold = 2,
            Cancelled = 3,
            Completed = 4
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int? VenueId
        {
            get; set;
        }

        [JsonProperty("leadId")]
        public int? LeadId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("status")]
        public EventStatusOptions Status
        {
            get; set;
        }

        [JsonProperty("priority")]
        public string Priority
        {
            get; set;
        }

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("companyId")]
        public int? CompanyId
        {
            get; set;
        }

        [JsonProperty("companyContactId")]
        public int? CompanyContactId
        {
            get; set;
        }

        [JsonProperty("assignedUserId")]
        public int? AssignedUserId
        {
            get; set;
        }

        [JsonProperty("assignedUserFullName")]
        public string AssignedUserFullName
        {
            get; set;
        }

        [JsonProperty("assignedUserEmail")]
        public string AssignedUserEmail
        {
            get; set;
        }

        [JsonProperty("endDatetime")]
        public DateTime? EndDatetime
        {
            get; set;
        }

        [JsonProperty("startDatetime")]
        public DateTime? StartDatetime
        {
            get; set;
        }

        [JsonProperty("progress")]
        public int Progress
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
    }
}