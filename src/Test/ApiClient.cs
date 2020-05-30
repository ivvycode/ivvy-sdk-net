using System.Threading.Tasks;
using Ivvy.API.Test;

namespace Ivvy.API
{
    public partial class ApiClient
    {
        /// <summary>
        /// Pings the iVvy api. Useful for testing.
        /// </summary>
        public async Task<ResultOrError<Pong>> PingAsync()
        {
            return await CallAsync<Pong>("test", "ping", null);
        }
    }
}