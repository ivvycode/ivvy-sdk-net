using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <summary>
        /// Returns a specific invoice.
        /// </summary>
        public async Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id)
        {
            return await CallAsync<Invoice.Invoice>(
                "invoice", "getInvoice", new
                {
                    id,
                }
            );
        }

        /// <summary>
        /// Returns a collection of invoices.
        /// </summary>
        public async Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(
            int perPage, int start, Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<Invoice.Invoice>>(
                "invoice", "getInvoiceList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Adds a payment to an invoice.
        /// </summary>
        public async Task<ResultOrError<ResultObject>> AddInvoicePayment(Invoice.AddPayment invoicePayment)
        {
            return await CallAsync<ResultObject>(
                "invoice", "addPayment", invoicePayment
            );
        }
    }
}