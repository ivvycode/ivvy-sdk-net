using System;
using Ivvy.API.Json;
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

        [JsonProperty("companyId")]
        public int? CompanyId
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

        [JsonProperty("utmSource")]
        public string UtmSource
        {
            get; set;
        }

        [JsonProperty("utmMedium")]
        public string UtmMedium
        {
            get; set;
        }

        [JsonProperty("utmCampaign")]
        public string UtmCampaign
        {
            get; set;
        }

        [JsonProperty("utmTerm")]
        public string UtmTerm
        {
            get; set;
        }

        [JsonProperty("utmContent")]
        public string UtmContent
        {
            get; set;
        }

        [JsonProperty("referralContactId")]
        public int? ReferralContactId
        {
            get; set;
        }

        [JsonProperty("referralContact")]
        public Contact.Contact ReferralContact
        {
            get; set;
        }

        [JsonProperty("referralCompanyId")]
        public int? ReferralCompanyId
        {
            get; set;
        }

        [JsonProperty("referralCompany")]
        public Contact.Contact ReferralCompany
        {
            get; set;
        }

        [JsonProperty("confirmedQuoteId")]
        public int? ConfirmedQuoteId
        {
            get; set;
        }

        [JsonProperty("confirmedQuoteStatus")]
        public int? ConfirmedQuoteStatus
        {
            get; set;
        }

        [JsonProperty("cancelledQuoteId")]
        public int? CancelledQuoteId
        {
            get; set;
        }

        [JsonProperty("lostToCompetition")]
        public int? LostToCompetition
        {
            get; set;
        }

        [JsonProperty("closedDate")]
        public DateTime? ClosedDate
        {
            get; set;
        }

        [JsonProperty("customFields")]
        public CustomField CustomFields
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
