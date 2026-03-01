using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ivvy.API.Json.Converters
{
    /// <summary>
    /// Handles deserialization of int[] properties that the iVvy API may return
    /// as either a JSON array (e.g. [1, 2, 3]) or a JSON object with integer keys
    /// (e.g. {"3485": ...}). When the value is an object, the keys are parsed as
    /// the integer array elements.
    /// </summary>
    public class IntArrayOrObjectConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(int[]);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonToken.StartArray)
            {
                return serializer.Deserialize<int[]>(reader);
            }

            if (reader.TokenType == JsonToken.StartObject)
            {
                var obj = JObject.Load(reader);
                var result = new List<int>();
                foreach (var property in obj.Properties())
                {
                    if (int.TryParse(property.Name, out var key))
                    {
                        result.Add(key);
                    }
                }
                return result.ToArray();
            }

            throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing int[].");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
