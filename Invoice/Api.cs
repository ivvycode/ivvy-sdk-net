using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API;
using Ivvy.API.Invoice;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a specific invoice.
        /// </summary>
        public async Task<ResultOrError<Invoice.Invoice>> GetInvoiceAsync(int id)
        {
            return await this.CallAsync<Invoice.Invoice>(
                "invoice", "getInvoice", new { id = id }
            );
        }

        /// <summary>
        /// Returns a collection of invoices.
        /// </summary>
        public async Task<ResultOrError<ResultList<Invoice.Invoice>>> GetInvoiceListAsync(
            int perPage, int start, Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<Invoice.Invoice>>(
                "invoice", "getInvoiceList", new {
                    perPage = perPage,
                    start = start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Adds a payment to an invoice.
        /// </summary>
        public async Task<ResultOrError<ResultObject>> AddInvoicePayment(AddPayment invoicePayment)
        {
            return await this.CallAsync<ResultObject>(
                "invoice", "addPayment", invoicePayment
            );
        }
    }
}