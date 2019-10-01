using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a collection of lead stages.
        /// </summary>
        public async Task<ResultOrError<ResultList<CRM.LeadStages>>> GetLeadStageListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await this.CallAsync<ResultList<CRM.LeadStages>>(
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
        public async Task<ResultOrError<ResultList<CRM.LeadTypes>>> GetLeadTypeListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await this.CallAsync<ResultList<CRM.LeadTypes>>(
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