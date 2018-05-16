using Ivvy.API.Subscription;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the subscription group list asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync();
    }
}
