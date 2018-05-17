using Ivvy.API.Helper;
using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.EmailLog
{
    public class EmailLog : ISerializable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("contactId")]
        public int? ContactId { get; set; }

        [JsonProperty("eventId")]
        public int? EventId { get; set; }

        [JsonProperty("userId")]
        public int? UserId { get; set; }

        [JsonProperty("refType")]
        public EnumHelper.EmailRefType EmailRefType { get; set; }

        [JsonProperty("type")]
        public EnumHelper.EmailType EmailType { get; set; }

        [JsonProperty("refId")]
        public int RefId { get; set; }

        [JsonProperty("from")]
        public string FromAddress { get; set; }

        [JsonProperty("to")]
        public string ToAddress { get; set; }

        [JsonProperty("bcc")]
        public string BccAddress { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("sentTime")]
        public string SentTime { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
