using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific invoice.
        /// </summary>
        Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id);

        /// <summary>
        /// Returns a collection of invoices.
        /// </summary>
        Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(
            int perPage, int start, Dictionary<string, string> filterRequest);
    }
}
