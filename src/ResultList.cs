using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ivvy.API
{
    /// <summary>
    /// This class is used to encapsulate the result of an api method call
    /// that returns a collection of data.
    /// </summary>
    public sealed class ResultList<T> : Ivvy.API.Json.ISerializable
    {
        /// <summary>
        /// The metadata details of the collection result.
        /// </summary>
        [JsonProperty("meta")]
        public Metadata Meta
        {
            get; set;
        }

        /// <summary>
        /// The collection of data returned by the api method call.
        /// </summary>
        [JsonProperty("results")]
        public List<T> Results
        {
            get; set;
        }

        /// <summary>
        /// This class is used to encapsulate the metadata details.
        /// </summary>
        public class Metadata
        {
            /// <summary>
            /// The total number of items in the collection.
            /// </summary>
            [JsonProperty("totalResults")]
            public int TotalCount
            {
                get; set;
            }

            /// <summary>
            /// The starting index of the results in the collection.
            /// </summary>
            [JsonProperty("start")]
            public int Start
            {
                get; set;
            }

            /// <summary>
            /// The number of items that were requested.
            /// </summary>
            [JsonProperty("perPage")]
            public int PerPage
            {
                get; set;
            }

            /// <summary>
            /// The number of items that were returned.
            /// </summary>
            [JsonProperty("count")]
            public int Count
            {
                get; set;
            }
        }
    }
}