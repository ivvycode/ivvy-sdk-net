using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific event.
        /// </summary>
        /// <param name="id">The unique id of the event..</param>
        /// <returns></returns>
        Task<ResultOrError<Event.Event>> GetEventAsync(int id);

        /// <summary>
        /// Returns a collection of events.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Event>>> GetEventListAsync(int perPage, int start,
            Dictionary<string, string> filterRequest = null, Event.GetEventListOptions options = null);

        /// <summary>
        /// Returns a collection of event attendees.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Attendee>>> GetEventAttendeeListAsync(
            int eventId, int perPage, int start, Dictionary<string, string> filterRequest = null);

        /// <summary>
        /// Returns a collection of event attendees across many events in the account.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Attendee>>> GetAttendeeListForAccountAsync(
            int perPage, int start, Dictionary<string, string> filterRequest = null);

        /// <summary>
        /// Returns a collection of event registrations.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Registration>>> GetEventRegistrationListAsync(
            int eventId, int perPage, int start, Dictionary<string, string> filterRequest = null);

        /// <summary>
        /// Returns a collection of event registrations across many events in the account.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Registration>>> GetRegistrationListForAccountAsync(
            int perPage, int start, Dictionary<string, string> filterRequest = null);
    }
}
