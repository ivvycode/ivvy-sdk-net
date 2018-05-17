using Ivvy.Test;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Pings the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<Pong>> PingAsync();
    }
}
