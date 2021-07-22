using System;
using System.Threading.Tasks;

namespace Ivvy.API
{
    public class ApiClientEvents
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