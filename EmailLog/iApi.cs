using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<ResultList<EmailLog.EmailLog>>> GetEmailLogList(int perPage, int start,
            Dictionary<string, string> filterRequest);
    }
}
