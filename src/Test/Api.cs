using System.Threading.Tasks;
using Ivvy.Test;

namespace Ivvy
{
    public partial class Api
    {
        /// <summary>
        /// Pings the iVvy api. Useful for testing.
        /// </summary>
        public async Task<ResultOrError<Pong>> PingAsync()
        {
            return await this.CallAsync<Pong>("test", "ping", null);
        }
    }
}