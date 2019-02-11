using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ivvy
{
    public  class Result<T>
    {

        [JsonProperty("asyncId")]
        public string AsyncId { get; set; }

        [JsonProperty("results")]
        public List<BatchResponse<T>> Results { get; set; }
    }
}
