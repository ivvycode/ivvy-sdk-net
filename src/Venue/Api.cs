using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        public async Task<ResultOrError<Venue.Venue>> GetVenueAsync(
            int id)
        {
            return await this.CallAsync<Venue.Venue>(
                "venue", "getVenue", new { id = id }
            );
        }

        /// <summary>
        /// Returns a collection of venue accommodation rooms.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await this.CallAsync<ResultList<Venue.Room>>(
                "venue", "getVenueRoomList", new { venueId = venueId, perPage = perPage, start = start }
            );
        }

        /// <summary>
        /// Returns a collection of venue rate plans.
        /// </summary>
        public async Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(
            int venueId,
            int perPage,
            int start)
        {
            return await this.CallAsync<ResultList<Venue.RatePlan>>(
                "venue", "getVenueRatePlanList", new { venueId = venueId, perPage = perPage, start = start }
            );
        }
    }
}