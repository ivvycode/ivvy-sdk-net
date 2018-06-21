using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific invoice.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id);

        /// <summary>
        /// Returns a collection of invoices.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(
            int perPage, int start, Dictionary<string, string> filterRequest);
    }
}
