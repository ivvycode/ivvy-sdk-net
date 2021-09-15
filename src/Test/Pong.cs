using System;
using Ivvy.API.Json;
using Newtonsoft.Json;

namespace Ivvy.API.Test
{
    /// <summary>
    /// This class encapsulates the result of the ping method.
    /// </summary>
    public class Pong : ISerializable
    {
        [JsonProperty("ack")]
        public DateTime? Ack
        {
            get; set;
        }
    }
}