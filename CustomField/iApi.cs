using Ivvy.API.CustomField;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the custom field defination.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<List<CustomField>>> GetCustomFieldDefination();
    }
}
