using System;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM opportunity.
    /// </summary>
    public class Opportunity : Lead
    {
        [JsonProperty("venueId")]
        public int VenueId
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
    }
}
