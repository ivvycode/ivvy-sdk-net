using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Venue.Venue>> GetVenueAsync(int id);

        /// <summary>
        /// Returns a collection of venue accommodation rooms.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a collection of venue rate plans.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a specific venue booking.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Venue.Booking>> GetVenueBookingAsync(int venueId, int id);

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy venue.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListAsync(int venueId, int perPage, int start,
            Dictionary<string, string> filterRequest);

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy account.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListForAccountAsync(int perPage, int start,
            Dictionary<string, string> filterRequest);
    }
}
