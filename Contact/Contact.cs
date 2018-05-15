using Ivvy.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using static Ivvy.API.Helper.EnumHelper;

namespace Ivvy.Contact
{
    /// <summary>
    /// An iVVy contact.
    /// </summary>
    public class Contact : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }
        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("status")]
        public EmailStatus EmailStatus { get; set; }

        [JsonProperty("smsStatus")]
        public SmsStatus SmsStatus { get; set; }

        [JsonProperty("customFields")]
        public List<CustomField> customFields { get; set; }

        [JsonProperty("groups")]
        public List<SubscriptionGroup> groups { get; set; }
    }

    public class CustomField : ISerializable
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }

    public class SubscriptionGroup : ISerializable
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }
    }

}