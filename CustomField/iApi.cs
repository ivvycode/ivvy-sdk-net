using Ivvy.API.CustomField;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<List<CustomField>>> GetCustomFieldDefination();
    }
}
