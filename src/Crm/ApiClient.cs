using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Crm;

namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <summary>
        /// Returns a collection of lead stages.
        /// </summary>
        public async Task<ResultOrError<ResultList<LeadStage>>> GetLeadStageListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<LeadStage>>(
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
        public async Task<ResultOrError<ResultList<LeadType>>> GetLeadTypeListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<LeadType>>(
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
        public async Task<ResultOrError<ResultList<Opportunity>>> GetOpportunityListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<Opportunity>>(
                "crm", "getOpportunityList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                });
        }

        /// <summary>
        /// Adds or updates an opportunity.
        /// </summary>
        public async Task<ResultOrError<ResultObject>> AddOrUpdateOpportunityAsync(Opportunity opportunity)
        {
            return await CallAsync<ResultObject>(
                "venue", "addOrUpdateOpportunity", opportunity
            );
        }
    }
}