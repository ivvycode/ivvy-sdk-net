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
            return await CallAsync<ResultList<Crm.LeadStage>>(
                "crm", "getLeadStageList", new
                {
                    perPage,
                    start,
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
            return await CallAsync<ResultList<Crm.LeadType>>(
                "crm", "getLeadTypeList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Returns a collection of opportunities.
        /// </summary>
        public async Task<ResultOrError<ResultList<Crm.Opportunity>>> GetOpportunityListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<Crm.Opportunity>>(
                "crm", "getOpportunityList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                });
        }
    }
}