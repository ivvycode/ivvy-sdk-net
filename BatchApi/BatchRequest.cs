using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ivvy
{
    public class BatchRequest<T>
    {
        [JsonProperty("jobs")]
        public List<T> Jobs { get; set; }

        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }
    }
}
