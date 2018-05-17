using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the invoice asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id);

        /// <summary>
        /// Gets the invoice list asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(int perPage, int start, Dictionary<string, string> filterRequest);

        /// <summary>
        /// Gets the venue booking list asynchronous.
        /// </summary>
        /// <param name="venueId">The venue identifier.</param>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Booking.Booking>>> GetVenueBookingListAsync(int venueId, int perPage, int start, Dictionary<string, string> filterRequest);

        /// <summary>
        /// Gets the venue booking asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<object>>> GetVenueBookingAsync(int perPage, int start, Dictionary<string, string> filterRequest);
    }
}
