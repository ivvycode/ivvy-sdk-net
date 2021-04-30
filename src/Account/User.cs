using Newtonsoft.Json;

namespace Ivvy.API.Account
{
    public class User
    {
        public enum StatusOptions
        {
            Active = 1,
            Inactive = 2
        }

        public enum UserTypeOptions
        {
            Normal = 1,
            AbstractReviewer = 2,
            EventClient = 3,
            APIThirdPartyUser = 4,
            MeetingBooker = 5
        }

        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }

        [JsonProperty("salutation")]
        public string Salutation
        {
            get; set;
        }

        [JsonProperty("firstName")]
        public string FirstName
        {
            get; set;
        }

        [JsonProperty("middleName")]
        public string MiddleName
        {
            get; set;
        }

        [JsonProperty("lastName")]
        public string LastName
        {
            get; set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get; set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get; set;
        }

        [JsonProperty("phoneMobile")]
        public string PhoneMobile
        {
            get; set;
        }

        [JsonProperty("currentStatus")]
        public StatusOptions CurrentStatus
        {
            get; set;
        }

        [JsonProperty("userType")]
        public UserTypeOptions UserType
        {
            get; set;
        }

        [JsonProperty("groupId")]
        public int GroupId
        {
            get; set;
        }

        [JsonProperty("lastLoginDate")]
        public string LastLoginDate
        {
            get; set;
        }

        [JsonProperty("createdDate")]
        public string CreatedDate
        {
            get; set;
        }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate
        {
            get; set;
        }
    }
}
