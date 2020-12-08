using System;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM opportunity.
    /// </summary>
    public class Opportunity
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
        {
            get; set;
        }

        [JsonProperty("venueId")]
        public int VenueId
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

        [JsonProperty("stageId")]
        public int? StageId
        {
            get; set;
        }

        [JsonProperty("typeId")]
        public int? TypeId
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

        [JsonProperty("referralCompanyId")]
        public int? ReferralCompanyId
        {
            get; set;
        }

        [JsonProperty("referralContactId")]
        public int? ReferralContactId
        {
            get; set;
        }

        [JsonProperty("companyLeadContactId")]
        public int? CompanyLeadContactId
        {
            get; set;
        }

        [JsonProperty("stageReasonId")]
        public int? StageReasonId
        {
            get; set;
        }

        [JsonProperty("closedDate")]
        public DateTime? ClosedDate
        {
            get; set;
        }
    }
}