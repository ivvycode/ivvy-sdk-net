using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Contact
{
    public class CustomField : ISerializable
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
