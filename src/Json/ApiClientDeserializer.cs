using Ivvy.API.Json.Converters;
using Newtonsoft.Json;

namespace Ivvy.API.Json
{
    public class ApiClientDeserializer : IApiClientDeserializer
    {
        public ResultOrError<T> Deserialize<T>(string encodedMessage) where T : new()
        {
            return JsonConvert.DeserializeObject<ResultOrError<T>>(encodedMessage, new ResponseConverter<T>());
        }
    }
}
