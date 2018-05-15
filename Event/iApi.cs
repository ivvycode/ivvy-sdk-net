using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the event asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Event.Event>> GetEventAsync(int id);

        /// <summary>
        /// Gets the event list asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Event>>> GetEventListAsync(int perPage, int start, Dictionary<string, string> filterRequest = null, GetEventListOptions options = null);
        
        /// <summary>
        /// Gets the event attendee list asynchronous.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<EventAttendee.EventAttendee>>> GetEventAttendeeListAsync(int eventId, int perPage, int start, Dictionary<string, string> filterRequest = null);

        /// <summary>
        /// Gets the event attendee list asynchronous without event identifier.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<EventAttendee.EventAttendee>>> GetEventAttendeeListAsyncWithoutEventId(int perPage, int start, Dictionary<string, string> filterRequest = null);

        /// <summary>
        /// Gets the event registration list asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<EventRegistration.EventRegistration>>> GetEventRegistrationListAsync(int perPage,
            int start, Dictionary<string, string> filterRequest = null);
    }
}
