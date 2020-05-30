using System;
using Newtonsoft.Json;
using Ivvy.Json;

namespace Ivvy.Test
{
    /// <summary>
    /// This class encapsulates the result of the ping method.
    /// </summary>
    public class Pong : ISerializable
    {
        [JsonProperty("ack")]
        public DateTime Ack
        {
            get; set;
        }
    }
}