using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ivvy.API.Json
{
    public class ApiClientSerializer : IApiClientSerializer
    {
        public string Serialize(object requestData)
        {
            return requestData == null
                ? string.Empty
                : JsonConvert.SerializeObject(
                requestData,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter>()
                    {
                        new IsoDateTimeConverter() { DateTimeFormat = Utils.DateTimeFormat }
                    }
                }
            );
        }
    }
}
