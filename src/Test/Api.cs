using System.Threading.Tasks;
using Ivvy.Test;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Pings the iVvy api. Useful for testing.
        /// </summary>
        public async Task<ResultOrError<Ping>> PingAsync()
        {
            return await this.CallAsync<Ping>("test", "ping", null);
        }
    }
}