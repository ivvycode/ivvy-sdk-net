using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ivvy
{
    /// <summary>
    /// This class is used to encapsulate the result of an api method call.
    /// </summary>
    public class ResultOrError<T>
    {
        /// <summary>
        /// The error code on error.
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode;

        /// <summary>
        /// The specific error code on error.
        /// </summary>
        [JsonProperty("specificCode")]
        public string ErrorCodeSpecific;

        /// <summary>
        /// The error message on error.
        /// </summary>
        [JsonProperty("message")]
        public string ErrorMessage;

        /// <summary>
        /// Any additional messages on error.
        /// </summary>
        [JsonProperty("additionalMessages")]
        public Dictionary<string, string> AdditionalMessages;

        /// <summary>
        /// The result of a successful api method call.
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// Returns whether or not the api method call was successful.
        /// </summary>
        public bool IsSuccess()
        {
            return ErrorCode == null;
        }
    }
}