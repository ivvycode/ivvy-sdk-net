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

        /// <summary>
        /// Returns a collection of events.
        /// </summary>
        public async Task<ResultOrError<ResultList<Event.Event>>> GetEventListAsync(
            int perPage,
            int start,
            GetEventListOptions options = null)
        {
            if (options == null)
            {
                options = new GetEventListOptions();
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
                }
            );
        }
    }
}