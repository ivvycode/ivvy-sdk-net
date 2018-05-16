using Ivvy.API.Subscription;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        public async Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync()
        {
            return await this.CallAsync<List<SubscriptionGroup>>(
                "contact", "getSubscriptionGroupList", new { }
            );
        }

    }
}
