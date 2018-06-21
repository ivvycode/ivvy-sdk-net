using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.Account
{
    public class CustomField : ISerializable
    {
        public enum FieldTypes
        {
            SmallText = 0,
            LargeText = 1,
            SingleSelect = 2,
            MultipleSelect = 3,
            Address = 4,
            Date = 5,
            File = 6,
            StaticText = 7,
            WholeNumber = 8
        }

        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("fieldType")]
        public FieldTypes FieldType { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("selectValues")]
        public object SelectValues { get; set; }

        [JsonProperty("fileTypes")]
        public string[] FileTypes { get; set; }
    }
}
