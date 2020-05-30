using Newtonsoft.Json;

namespace Ivvy.API
{
    /// <summary>
    /// This class is used to encapsulate the result of an api method call
    /// that only returns success or not.
    /// </summary>
    public class ResultSuccess : Ivvy.API.Json.ISerializable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the result is successful.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }
    }
}