using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Gets the invoice asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id)
        {
            return await this.CallAsync<Invoice.Invoice>(
                "invoice", "getInvoice", new { id = id }
            );
        }

        /// <summary>
        /// Gets the invoice list asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        public async Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(int perPage, int start, Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<Invoice.Invoice>>(
                "invoice", "getInvoiceList", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest,
                });
        }

        public async Task<ResultOrError<ResultList<Booking.Booking>>> GetVenueBookingListAsync(int venueId, int perPage,
            int start, Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<Booking.Booking>>(
                "venue", "getBookingList", new
                {
                    venueId = venueId,
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                });
        }

        public async Task<ResultOrError<ResultList<object>>> GetVenueBookingAsync(int perPage, int start,
            Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<object>>(
                "venue", "getBooking", new
                {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                });
        }
    }
}
