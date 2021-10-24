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
        Task<ResultOrError<ResultList<Crm.LeadStage>>> GetLeadStageListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of lead types.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Crm.LeadType>>> GetLeadTypeListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of lead sources.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<LeadSource>>> GetLeadSourceListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Adds or updates a lead source.
        /// </summary>
        /// <param name="source">Source object</param>
        /// <returns></returns>
        Task<ResultOrError<ResultObject>> AddOrUpdateLeadSourceAsync(LeadSource source);

        /// <summary>
        /// Returns a collection of lead channels.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<LeadChannel>>> GetLeadChannelListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Adds or updates a lead channel.
        /// </summary>
        /// <param name="channel">Channel object</param>
        /// <returns></returns>
        Task<ResultOrError<ResultObject>> AddOrUpdateLeadChannelAsync(LeadChannel channel);

        /// <summary>
        /// Returns a collection of opportunities.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        Task<ResultOrError<ResultList<Crm.Opportunity>>> GetOpportunityListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Adds or updates an opportunity.
        /// </summary>
        /// <param name="opportunity">Opportunity object</param>
        /// <returns></returns>
        Task<ResultOrError<ResultObject>> AddOrUpdateOpportunityAsync(Opportunity opportunity);

        /// <summary>
        /// Returns a collection of tasks.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        Task<ResultOrError<ResultList<Crm.EventTask>>> GetTaskListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Adds or updates a task.
        /// </summary>
        /// <param name="task">EventTask object</param>
        /// <returns></returns>
        Task<ResultOrError<ResultObject>> AddOrUpdateTaskAsync(EventTask task);

        /// <summary>
        /// Returns a collection of activities.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        Task<ResultOrError<ResultList<Crm.EventActivity>>> GetActivityListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Adds or updates an activity.
        /// </summary>
        /// <param name="activity">EventActivity object</param>
        /// <returns></returns>
        Task<ResultOrError<ResultObject>> AddOrUpdateActivityAsync(EventActivity activity);

        /// <summary>
        /// Returns the description of how an opportunity should be allocated based the online booking rules of a venue.
        /// </summary>
        /// <param name="venueId">The id of the venue.</param>
        /// <param name="opportunityType">The type of opportunity.</param>
        /// <param name="eventTypeId">The id of the venue event type.</param>
        /// <param name="estimatedValue">The estimated value of the opportunity.</param>
        Task<ResultOrError<HowToAllocateOpportunity>> GetHowToAllocateOpportunity(
            int venueId,
            HowToAllocateOpportunity.OpportunityTypes opportunityType,
            int eventTypeId,
            int estimatedValue);
    }
}