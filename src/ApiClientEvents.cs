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
            OnBeforeApiCalled = details => Task.CompletedTask;
            OnAfterApiCalled = details => Task.CompletedTask;
        }

        public Func<ApiCallDetails, Task> OnAfterApiCalled
        {
            get; set;
        }

        public Func<ApiCallRequestDetails, Task> OnBeforeApiCalled
        {
            get; set;
        }

        public virtual Task AfterApiCalledAsync(ApiCallDetails details) => OnAfterApiCalled(details);

        public virtual Task BeforeApiCalledAsync(ApiCallRequestDetails details) => OnBeforeApiCalled(details);
    }
}