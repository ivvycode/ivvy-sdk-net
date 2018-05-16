using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the contact asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Contact.Contact>> GetContactAsync(int id);

        /// <summary>
        /// Gets the contact list asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start);

        /// <summary>
        /// Gets the contact list asynchronous.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start, Dictionary<string, string> filterRequest);

        /// <summary>
        /// Adds the or update contact asynchronous.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <returns></returns>
        Task<ResultOrError<Contact.ContactResult>> AddOrUpdateContactAsync(Contact.Contact contact);

        /// <summary>
        /// Gets the company asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<ResultOrError<Contact.Company>> GetCompanyAsync(int id);
    }
}
