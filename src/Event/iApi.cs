using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<Event.Event>> GetEventAsync(int id);
        Task<ResultOrError<ResultList<Event.Event>>> GetEventListAsync(int perPage, int start, GetEventListOptions options = null);
    }
}
