using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a collection of lead stages.
        /// </summary>
        public async Task<ResultOrError<ResultList<Crm.LeadStage>>> GetLeadStageListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await this.CallAsync<ResultList<Crm.LeadStage>>(
                "crm", "getLeadStageList", new {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Returns a collection of lead types.
        /// </summary>
        public async Task<ResultOrError<ResultList<Crm.LeadType>>> GetLeadTypeListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await this.CallAsync<ResultList<Crm.LeadType>>(
                "crm", "getLeadTypeList", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }
    }
}