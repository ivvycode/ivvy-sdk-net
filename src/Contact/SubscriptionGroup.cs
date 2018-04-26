using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Contact
{
    public class SubscriptionGroup :ISerializable
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }
    }
}
