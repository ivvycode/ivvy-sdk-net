using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions.Installation.Setup
{
    /// <summary>
    /// This class encapsulates the details returned by iVvy when
    /// an extension verifies an event setup request.
    /// </summary>
    public sealed class EventVerifySetupResponse
    {
        [JsonProperty("accountId")]
        public string AccountId
        {
            get; set;
        }

        [JsonProperty("accountDomain")]
        public string AccountDomain
        {
            get; set;
        }

        [JsonProperty("eventId")]
        public string EventId
        {
            get; set;
        }

        [JsonProperty("eventHashId")]
        public string EventHashId
        {
            get; set;
        }
    }
}