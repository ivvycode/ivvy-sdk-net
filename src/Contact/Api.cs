using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.Contact;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns a specific contact.
        /// </summary>
        public async Task<ResultOrError<Contact.Contact>> GetContactAsync(
            int id)
        {
            return await this.CallAsync<Contact.Contact>(
                "contact", "getContact", new { id = id }
            );
        }

        /// <summary>
        /// Returns a collection of contacts.
        /// </summary>
        public async Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(
            int perPage, int start)
        {
            return await this.CallAsync<ResultList<Contact.Contact>>(
                "contact", "getContactList", new { perPage = perPage, start = start }
            );
        }

        public async Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start, Dictionary<string, string> filterRequest)
        {
            return await this.CallAsync<ResultList<Contact.Contact>>(
                "contact", "getContactList", new { perPage = perPage, start = start, filter = filterRequest, }
            );
        }

        /// <summary>
        /// Adds or updates a contact.
        /// </summary>
        public async Task<ResultOrError<Contact.ContactResult>> AddOrUpdateContactAsync(
            Contact.Contact contact)
        {
            return await this.CallAsync<Contact.ContactResult>(
                "contact", "addOrUpdateContact", contact
            );
        }

        public async Task<ResultOrError<Company>> GetCompanyAsync(int id)
        {
            return await this.CallAsync<Contact.Company>(
                "contact", "getCompany", new { id = id }
            );
        }
    }
}