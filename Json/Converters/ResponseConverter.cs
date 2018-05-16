using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Ivvy.Json.Converters
{
    /// <summary>
    /// This class is used to convert the json response of the iVvy api.
    /// </summary>
    public class ResponseConverter<T> : JsonConverter where T : new()
    {
        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Ivvy.ResultOrError<T>)
                || objectType is Ivvy.Json.ISerializable;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            reader.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            reader.DateFormatString = Utils.DateTimeFormat;
            reader.DateParseHandling = DateParseHandling.DateTime;
            serializer.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            serializer.DateFormatString = Utils.DateTimeFormat;
            serializer.DateParseHandling = DateParseHandling.DateTime;

            var resultOrError = new ResultOrError<T>();

            if (reader.TokenType == JsonToken.StartObject)
            {
                var jsonObject = JObject.Load(reader);
                if (jsonObject["errorCode"] == null)
                {
                    T result = new T();
                    serializer.Populate(jsonObject.CreateReader(), result);
                    resultOrError.Result = result;
                }
                else
                {
                    serializer.Populate(jsonObject.CreateReader(), resultOrError);
                }
            }
            else
            {
                var jsonArray = JArray.Load(reader);
                T result = new T();
                serializer.Populate(jsonArray.CreateReader(), result);
                resultOrError.Result = result;
            }
            return resultOrError;
        }
    }
}