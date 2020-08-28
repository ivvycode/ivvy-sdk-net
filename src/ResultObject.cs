using Newtonsoft.Json;

namespace Ivvy.API
{
    /// <summary>
    /// This class is used to encapsulate the result of an api method call
    /// that adds or updates a model object.
    /// </summary>
    /// <seealso cref="Json.ISerializable" />
    public class ResultObject : Json.ISerializable
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ResultObject"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the error message (if success is false).
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        [JsonProperty("message")]
        public string Message
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the unique id of the model object.
        /// </summary>
        /// <value>
        /// The unique id of the model object.
        /// </value>
        [JsonProperty("id")]
        public int Id
        {
            get; set;
        }
    }
}