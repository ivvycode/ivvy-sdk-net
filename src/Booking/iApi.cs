using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<ResultList<Booking.Booking>>> GetAccountBookingListAsync(int perPage, int start, Dictionary<string, string> filterRequest);
    }
}
