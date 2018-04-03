using Ivvy.API.Subscription;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Gets the subscription group list asynchronous.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync()
        {
            return await this.CallAsync<List<SubscriptionGroup>>(
                "contact", "getSubscriptionGroupList", new { }
            );
        }
    }
}
