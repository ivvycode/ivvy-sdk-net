using Ivvy.Common;
using Ivvy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Ivvy.Contact
{
    /// <summary>
    /// An iVvy contact.
    /// </summary>
    public class Contact : ISerializable
    {
        public enum EmailStatusOptions
        {
            Subscribed = 1,
            Unsubscribed = 2,
            Bounced = 3,
            Registering = 4,
            NoMarketing = 5
        }

        public enum SmsStatusOptions
        {
            Subscribed = 1,
            Unsubscribed = 2,
            Failed = 3,
            NoMarketing = 4
        }

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
        public DateTime CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate { get; set; }

        [JsonProperty("status")]
        public EmailStatusOptions? EmailStatus { get; set; }

        [JsonProperty("smsStatus")]
        public SmsStatusOptions? SmsStatus { get; set; }

        [JsonProperty("customFields")]
        public List<CustomField> CustomFields { get; set; }

        [JsonProperty("groups")]
        public List<SubscriptionGroup> Groups { get; set; }

        [JsonProperty("companiesData")]
        public List<Company> CompaniesData { get; set; }

        [JsonProperty("companies")]
        public List<int> Companies { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    /// <summary>
    /// A contact's custom field value.
    /// </summary>
    public class CustomField : ISerializable
    {
        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("fieldType")]
        public Ivvy.Account.CustomField.FieldTypes FieldType { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        /// <summary>
        /// Returns whether or not this field is an address custom field.
        /// </summary>
        public bool IsAddress()
        {
            return FieldType == Ivvy.Account.CustomField.FieldTypes.Address;
        }

        /// <summary>
        /// Returns the custom field value as an address if the field
        /// type is address.
        /// </summary>
        public Address ValueAsAddress()
        {
            if (!IsAddress()) {
                return null;
            }
            if (Value == null) {
                return null;
            }
            if (!(Value is JObject)) {
                return null;
            }
            try {
                return ((JObject)Value).ToObject<Address>();
            }
            catch (Exception ex) {
                return null;
            }
        }
    }

    /// <summary>
    /// A contact's subscription group.
    /// </summary>
    public class SubscriptionGroup : ISerializable
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }
    }
}