using System;
using System.Threading.Tasks;

namespace Ivvy.API
{
    /// <summary>
    /// ApiClientEvents provides a default implementation of IApiClientEvents which does nothing.
    /// </summary>
    public class ApiClientEvents : IApiClientEvents
    {
        public ApiClientEvents()
        {
            OnAfterApiCalled = details => Task.CompletedTask;
        }

        public Func<ApiCallDetails, Task> OnAfterApiCalled
        {
            get; set;
        }

        public virtual Task AfterApiCalledAsync(ApiCallDetails details) => OnAfterApiCalled(details);
    }
}