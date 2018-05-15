﻿using Ivvy.API.Helper;
using Ivvy.Json;
using Newtonsoft.Json;

namespace Ivvy.API.CustomField
{
    public class CustomField : ISerializable
    {
        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("fieldType")]
        public EnumHelper.FieldType FieldType { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("selectValues")]
        public object SelectValues { get; set; }

        [JsonProperty("fileTypes")]
        public string FileTypes { get; set; }
    }
}
