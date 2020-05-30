using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific contact.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Contact.Contact>> GetContactAsync(int id);

        /// <summary>
        /// Returns a collection of contacts.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start, Dictionary<string, object> filterRequest);

        /// <summary>
        /// Adds or updates a contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <returns></returns>
        Task<ResultOrError<Contact.ContactResult>> AddOrUpdateContactAsync(Contact.Contact contact);

        /// <summary>
        /// Returns a specific company.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Contact.Company>> GetCompanyAsync(int id);

        /// <summary>
        /// Returns a collection of companies.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Contact.Company>>> GetCompanyListAsync(int perPage, int start, Dictionary<string, object> filterRequest);

        /// <summary>
        /// Adds or updates a company.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultObject>> AddOrUpdateCompanyAsync(Contact.Company company);
    }
}