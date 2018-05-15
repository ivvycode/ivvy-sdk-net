using Ivvy.Test;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        Task<ResultOrError<Pong>> PingAsync();
    }
}
