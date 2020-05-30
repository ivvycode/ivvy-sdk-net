using Ivvy.Test;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Pings the iVvy api. Useful for testing.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<Pong>> PingAsync();
    }
}