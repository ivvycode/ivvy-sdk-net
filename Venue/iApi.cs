using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the venue asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Venue.Venue>> GetVenueAsync(int id);

        /// <summary>
        /// Gets the venue room list asynchronous.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Gets the venue rate plan list asynchronous.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(int venueId, int perPage, int start);
    }
}
