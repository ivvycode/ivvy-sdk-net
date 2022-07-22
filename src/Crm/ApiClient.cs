using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Crm;

namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Lead>>> GetLeadListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<Lead>>(
                "crm", "getLeadList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

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
        public async Task<ResultOrError<ResultList<Crm.EventTask>>> GetTaskListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<Crm.EventTask>>(
                "crm", "getTaskList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                });
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateTaskAsync(EventTask task)
        {
            return await CallAsync<ResultObject>(
                "crm", "addOrUpdateTask", task
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Crm.EventActivity>>> GetActivityListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<Crm.EventActivity>>(
                "crm", "getActivityList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                });
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateActivityAsync(EventActivity activity)
        {
            return await CallAsync<ResultObject>(
                "crm", "addOrUpdateActivity", activity
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<LeadSource>>> GetLeadSourceListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<LeadSource>>(
                "crm", "getLeadSourceList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateLeadSourceAsync(
            LeadSource source)
        {
            return await CallAsync<ResultObject>(
                "crm", "addOrUpdateLeadSource", source);
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<LeadChannel>>> GetLeadChannelListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null)
        {
            return await CallAsync<ResultList<LeadChannel>>(
                "crm", "getLeadChannelList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateLeadChannelAsync(
            LeadChannel channel)
        {
            return await CallAsync<ResultObject>(
                "crm", "addOrUpdateLeadChannel", channel);
        }


        /// <inheritdoc />
        public async Task<ResultOrError<HowToAllocateOpportunity>> GetHowToAllocateOpportunity(
            int venueId,
            HowToAllocateOpportunity.OpportunityTypes opportunityType,
            int eventTypeId,
            int estimatedValue)
        {
            if (eventTypeId > 0)
            {
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
            else
            {
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