using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ivvy.API.Subscription;

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
