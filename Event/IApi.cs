using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific event.
        /// </summary>
        Task<ResultOrError<Event.Event>> GetEventAsync(int id);

        /// <summary>
        /// Returns a collection of events.
        /// </summary>
        Task<ResultOrError<ResultList<Event.Event>>> GetEventListAsync(
            int perPage, int start, Dictionary<string, string> filterRequest = null, Event.GetEventListOptions options = null);

        /// <summary>
        /// Returns a collection of event attendees.
        /// </summary>
        Task<ResultOrError<ResultList<Event.Attendee>>> GetEventAttendeeListAsync(
            int eventId, int perPage, int start, Dictionary<string, string> filterRequest = null);

        /// <summary>
        /// Returns a collection of event registrations.
        /// </summary>
        Task<ResultOrError<ResultList<Event.Registration>>> GetEventRegistrationListAsync(
            int eventId, int perPage, int start, Dictionary<string, string> filterRequest = null);
    }
}
