using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.Event;

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
            Dictionary<string, object> filterRequest = null, Event.GetEventListOptions options = null);

        /// <summary>
        /// Returns a collection of event attendees.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Attendee>>> GetEventAttendeeListAsync(
            int eventId, int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of event attendees across many events in the account.
        /// </summary>
        /// <param name="perPage">The per page records.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Attendee>>> GetAttendeeListForAccountAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Gets the invited contact list for account.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<InvitedContact>>> GetInvitedContactListForAccount(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Gets the invited contact list.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<InvitedContact>>> GetInvitedContactList(
            int eventId, int perPage, int start, Dictionary<string, object> filterRequest = null);

        /// <summary>
        /// Returns a collection of event registrations.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Registration>>> GetEventRegistrationListAsync(
            int eventId, int perPage, int start, Dictionary<string, object> filterRequest = null);


        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Event.Registration>>> GetRegistrationListForAccountAsync(
            int perPage, int start, Dictionary<string, object> filterRequest = null);

    }
}
