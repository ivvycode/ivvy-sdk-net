using Newtonsoft.Json;

namespace Ivvy.PlatformExtensions
{
    /// <summary>
    /// This class is used to encapsulate the result of an extension endpoint request.
    /// </summary>
    public class ResultOrError<T>
    {
        /// <summary>
        /// Whether or not the request was successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success
        {
            get; set;
        }

        /// <summary>
        /// The error message on error.
        /// </summary>
        [JsonProperty("message")]
        public string ErrorMessage
        {
            get; set;
        }

        /// <summary>
        /// The result of a successful extension endpoint request.
        /// </summary>
        [JsonProperty("response")]
        public T Result
        {
            get; set;
        }
    }
}