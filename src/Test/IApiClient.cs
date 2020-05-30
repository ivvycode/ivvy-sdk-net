using Ivvy.API.Test;
using System.Threading.Tasks;

namespace Ivvy.API
{
    public partial interface IApiClient
    {
        /// <summary>
        /// Pings the iVvy api. Useful for testing.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<Pong>> PingAsync();
    }
}