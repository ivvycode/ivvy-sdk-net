using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ivvy.API.Subscription;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync();
    }
}
