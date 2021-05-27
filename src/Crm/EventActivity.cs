using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM Event Activity.
    /// </summary>
    public class EventActivity : ISerializable
    {
        public enum SubTypeOptions
        {
            Meeting = 1,
            Call = 2,
            Email = 3,
        }

        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public string VenueId
        {
            get; set;
        }

        [JsonProperty("leadId")]
        public string LeadId
        {
            get; set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("subType")]
        public SubTypeOptions SubType
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("purposeName")]
        public string PurposeName
        {
            get; set;
        }

        [JsonProperty("purposeType")]
        public string PurposeType
        {
            get; set;
        }

        [JsonProperty("location")]
        public string Location
        {
            get; set;
        }

        [JsonProperty("contactId")]
        public string ContactId
        {
            get; set;
        }

        [JsonProperty("companyId")]
        public string CompanyId
        {
            get; set;
        }

        [JsonProperty("companyContactId")]
        public string CompanyContactId
        {
            get; set;
        }

        [JsonProperty("assignedUserId")]
        public string AssignedUserId
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

        [JsonProperty("startDatetime")]
        public DateTime? StartDatetime
        {
            get; set;
        }

        [JsonProperty("endDatetime")]
        public DateTime? EndDatetime
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