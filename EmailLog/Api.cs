using Ivvy.API.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        public async Task<ResultOrError<ResultList<EmailLog.EmailLog>>> GetEmailLogList(int perPage, int start, Dictionary<string, string> filterRequest)
        {
            return await CallAsync<ResultList<EmailLog.EmailLog>>(
                Constants.AccountApiNamespace
                , Constants.GetEmailLogListAction
                , new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }
    }
}
