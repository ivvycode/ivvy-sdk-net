using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Crm;

namespace Ivvy.API
{
    public partial interface IApiClient
    {
        /// <summary>
        /// Returns a collection of lead stages.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<LeadStage>>> GetLeadStageListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of lead types.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<LeadType>>> GetLeadTypeListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of opportunities.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        Task<ResultOrError<ResultList<Opportunity>>> GetOpportunityListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of user email addresses from opportunity allocation rules.
        /// </summary>
        /// <param name="venueId">The venue id.</param>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<OpportunityAllocationUserDetail>>> GetOpportunityAllocationRulesEmailListAsync(
            int venueId,
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Adds or updates an opportunity.
        /// </summary>
        /// <param name="opportunity">Opportunity object</param>
        Task<ResultOrError<ResultObject>> AddOrUpdateOpportunityAsync(Opportunity opportunity);
    }
}