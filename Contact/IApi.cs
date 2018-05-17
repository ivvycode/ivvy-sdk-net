using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns a specific contact.
        /// </summary>
        Task<ResultOrError<Contact.Contact>> GetContactAsync(int id);

        /// <summary>
        /// Returns a collection of contacts.
        /// </summary>
        Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start, Dictionary<string, string> filterRequest);

        /// <summary>
        /// Adds or updates a contact.
        /// </summary>
        Task<ResultOrError<Contact.ContactResult>> AddOrUpdateContactAsync(Contact.Contact contact);

        /// <summary>
        /// Returns a specific company.
        /// </summary>
        Task<ResultOrError<Contact.Company>> GetCompanyAsync(int id);
    }
}
