using System;
using System.Threading.Tasks;

namespace Ivvy.API
{
    /// <summary>
    /// IApiClientEvents provides a mechanism to hook into the iVvy api caller code.
    /// </summary>
    public interface IApiClientEvents
    {
        /// <summary>
        /// A function that is called after an iVvy api request is completed.
        /// </summary>
        Func<ApiCallDetails, Task> OnAfterApiCalled
        {
            get; set;
        }

        /// <summary>
        /// An iVvy api request is completed.
        /// </summary>
        Task AfterApiCalledAsync(ApiCallDetails details);
    }
}