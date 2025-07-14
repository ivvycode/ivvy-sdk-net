using System;
using Ivvy.API.Common;
using Newtonsoft.Json;

namespace Ivvy.API.Contact
{
    public class CompanyReference
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id
        {
            get; set;
        }

        [JsonProperty("businessName")]
        public string BusinessName
        {
            get; set;
        }
    }
}