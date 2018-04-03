using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Get Account Booking List by perpage and start index
        /// </summary>
        /// <param name="perPage"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public async Task<ResultOrError<ResultList<Booking.Booking>>> GetAccountBookingListAsync(
           int perPage, int start, Dictionary<string, string> filterRequest)
        {

            return await this.CallAsync<ResultList<Booking.Booking>>(
                "venue", "getBookingListForAccount", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                });
        }

    }
}