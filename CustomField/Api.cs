using Ivvy.API.CustomField;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns custom fields.
        /// </summary>
        public async Task<ResultOrError<List<CustomField>>> GetCustomFieldDefination()
        {
            return await this.CallAsync<List<CustomField>>(
                "contact", "getCustomFieldDefinition", null);
        }

    }
}
