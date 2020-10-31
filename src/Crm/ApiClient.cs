using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Crm;

namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateOpportunityAsync(Opportunity opportunity)
        {
            return await CallAsync<ResultObject>(
                "venue", "addOrUpdateOpportunity", opportunity
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<HowToAllocateOpportunity>> GetHowToAllocateOpportunity(
            int venueId,
            HowToAllocateOpportunity.OpportunityTypes opportunityType,
            int eventTypeId,
            int estimatedValue)
        {
            if (eventTypeId > 0) {
                return await CallAsync<HowToAllocateOpportunity>(
                    "crm", "getHowToAllocateOpportunity", new
                    {
                        venueId,
                        opportunityType,
                        eventTypeId,
                        estimatedValue
                    }
                );
            }
            else {
                return await CallAsync<HowToAllocateOpportunity>(
                    "crm", "getHowToAllocateOpportunity", new
                    {
                        venueId,
                        opportunityType,
                        estimatedValue
                    }
                );
            }
        }
    }
}