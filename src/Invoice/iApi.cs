using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id);
        Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(int perPage, int start, Dictionary<string, string> filterRequest);
        Task<ResultOrError<ResultList<Booking.Booking>>> GetVenueBookingListAsync(int venueId, int perPage, int start, Dictionary<string, string> filterRequest);
        Task<ResultOrError<ResultList<object>>> GetVenueBookingAsync(int perPage, int start, Dictionary<string, string> filterRequest);
    }
}
