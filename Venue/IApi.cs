using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        Task<ResultOrError<Venue.Venue>> GetVenueAsync(int id);

        /// <summary>
        /// Returns a collection of venue accommodation rooms.
        /// </summary>
        Task<ResultOrError<ResultList<Venue.Room>>> GetVenueRoomListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a collection of venue rate plans.
        /// </summary>
        Task<ResultOrError<ResultList<Venue.RatePlan>>> GetVenueRatePlanListAsync(int venueId, int perPage, int start);

        /// <summary>
        /// Returns a specific venue booking.
        /// </summary>
        Task<ResultOrError<Venue.Booking>> GetVenueBookingAsync(int venueId, int id);

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy venue.
        /// </summary>
        Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListAsync(
            int venueId, int perPage, int start, Dictionary<string, string> filterRequest);

        /// <summary>
        /// Returns a collection of venue bookings in an iVvy account.
        /// </summary>
        Task<ResultOrError<ResultList<Venue.Booking>>> GetVenueBookingListForAccountAsync(
            int perPage, int start, Dictionary<string, string> filterRequest);
    }
}
