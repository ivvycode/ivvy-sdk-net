using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Account
{
    /// <summary>
    /// The result of subscribing to account notifications.
    /// </summary>
    public class NotificationsResult : ISerializable
    {
        [JsonProperty("eventsSuccess")]
        public bool EventsSuccess
        {
            get; set;
        }

        [JsonProperty("eventsTopicId")]
        public string EventsTopicId
        {
            get; set;
        }

        [JsonProperty("venuesSuccess")]
        public bool VenuesSuccess
        {
            get; set;
        }

        [JsonProperty("venuesTopicId")]
        public string VenuesTopicId
        {
            get; set;
        }

        [JsonProperty("paymentsSuccess")]
        public bool PaymentsSuccess
        {
            get; set;
        }

        [JsonProperty("paymentsTopicId")]
        public string PaymentsTopicId
        {
            get; set;
        }

        [JsonProperty("crmSuccess")]
        public bool CrmSuccess
        {
            get; set;
        }

        [JsonProperty("crmTopicId")]
        public string CrmTopicId
        {
            get; set;
        }

        [JsonProperty("contactsSuccess")]
        public bool ContactsSuccess
        {
            get; set;
        }

        [JsonProperty("contactsTopicId")]
        public string ContactsTopicId
        {
            get; set;
        }

        [JsonProperty("companiesSuccess")]
        public bool CompaniesSuccess
        {
            get; set;
        }

        [JsonProperty("companiesTopicId")]
        public string CompaniesTopicId
        {
            get; set;
        }
    }
}