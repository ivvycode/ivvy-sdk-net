using System.Collections.Generic;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM lead.
    /// </summary>
    public class Lead
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
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

        [JsonProperty("companyId")]
        public int? CompanyId
        {
            get; set;
        }

        [JsonProperty("company")]
        public API.Contact.Company Company
        {
            get; set;
        }

        [JsonProperty("companyLeadContactId")]
        public int? CompanyLeadContactId
        {
            get; set;
        }

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("contact")]
        public API.Contact.Contact Contact
        {
            get; set;
        }

        [JsonProperty("qualityId")]
        public int? QualityId
        {
            get; set;
        }

        [JsonProperty("industryId")]
        public int? IndustryId
        {
            get; set;
        }

        [JsonProperty("sourceId")]
        public int? SourceId
        {
            get; set;
        }

        [JsonProperty("ownerUserId")]
        public int? OwnerUserId
        {
            get; set;
        }

        [JsonProperty("typeId")]
        public int? TypeId
        {
            get; set;
        }

        [JsonProperty("stageId")]
        public int? StageId
        {
            get; set;
        }

        [JsonProperty("stageReasonId")]
        public int? StageReasonId
        {
            get; set;
        }

        [JsonProperty("channelId")]
        public int? ChannelId
        {
            get; set;
        }

        [JsonProperty("customFields")]
        public List<CustomField> CustomFields
        {
            get; set;
        }

        [JsonProperty("ownerUser")]
        public OpportunityOwner OwnerUser
        {
            get; set;
        }
    }

    public class CustomField : ISerializable
    {
        [JsonProperty("fieldId")]
        public int FieldId
        {
            get; set;
        }


        [JsonProperty("fieldValue")]
        public object FieldValue
        {
            get; set;
        }
    }
}