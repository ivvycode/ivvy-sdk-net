using Ivvy.API.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a specific event.
        /// </summary>
        public async Task<ResultOrError<Event.Event>> GetEventAsync(
            int id)
        {
            return await this.CallAsync<Event.Event>(
                "event", "getEvent", new { id = id }
            );
        }

        public async Task<ResultOrError<ResultList<Event.Event>>> GetEventListAsync(int perPage, int start, Dictionary<string, string> filterRequest = null, GetEventListOptions options = null)
        {
            if (options == null)
            {
                options = new GetEventListOptions();
            }
            if (filterRequest == null)
            {
                filterRequest = new Dictionary<string, string>();
            }
            return await this.CallAsync<ResultList<Event.Event>>(
                "event", "getEventList", new
                {
                    perPage = perPage,
                    start = start,
                    includeVenueDetails = options.IncludeVenueDetails,
                    includeTicketDetails = options.IncludeTicketDetails,
                    includeInformationDetails = options.IncludeInformationDetails,
                    includeHomepageContent = options.IncludeHomePageContent,
                    filter = filterRequest
                }
            );
        }

        public async Task<ResultOrError<ResultList<EventAttendee.EventAttendee>>> GetEventAttendeeListAsync(int eventId, int perPage, int start, Dictionary<string, string> filterRequest = null)
        {
            return await this.CallAsync<ResultList<EventAttendee.EventAttendee>>(
                "event", "getAttendeeList", new
                {
                    eventId = eventId,
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        //TODO: change the name of method once api ready
        public async Task<ResultOrError<ResultList<EventAttendee.EventAttendee>>> GetEventAttendeeListAsyncWithoutEventId(
            int perPage
            , int start
            , Dictionary<string, string> filterRequest = null)
        {
            return await this.CallAsync<ResultList<EventAttendee.EventAttendee>>(
                "event", "getAttendeeListNew", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        public async Task<ResultOrError<ResultList<EventRegistration.EventRegistration>>> GetEventRegistrationListAsync(
            int perPage,
            int start, Dictionary<string, string> filterRequest = null)
        {
            return await CallAsync<ResultList<EventRegistration.EventRegistration>>(Constants.EventApiNamespace,
                Constants.GetEventRegistrationListAction
                , new
                {
                    perPage,
                    start,
                    filter = filterRequest
                });
        }
    }
}