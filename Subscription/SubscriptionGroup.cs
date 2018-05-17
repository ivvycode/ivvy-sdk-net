using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Subscription
{
    public class SubscriptionGroup : ISerializable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("memberCount")]
        public int MemberCount { get; set; }

        [JsonProperty("tagColour")]
        public string TagColour { get; set; }
    }
}
