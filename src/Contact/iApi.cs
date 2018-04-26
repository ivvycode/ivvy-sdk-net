using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<Contact.Contact>> GetContactAsync(int id);
        Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start);
        Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(int perPage, int start, Dictionary<string, string> filterRequest);
        Task<ResultOrError<Contact.ContactResult>> AddOrUpdateContactAsync(Contact.Contact contact);
        Task<ResultOrError<Contact.Company>> GetCompanyAsync(int id);
    }
}
