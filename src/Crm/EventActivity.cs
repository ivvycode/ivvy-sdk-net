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
            NotSet = 0,
            Meeting = 1,
            Call = 2,
            Email = 3,
        }

        public enum PurposeTypeOptions
        {
            Account = 1,
            Function = 2,
            Corporate = 3,
            Group = 4,
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

        [JsonProperty("subType")]
        public SubTypeOptions? SubType
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("purposeId")]
        public int? PurposeId
        {
            get; set;
        }

        [JsonProperty("purposeName")]
        public string PurposeName
        {
            get; set;
        }

        [JsonProperty("purposeType")]
        public PurposeTypeOptions? PurposeType
        {
            get; set;
        }

        [JsonProperty("location")]
        public string Location
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