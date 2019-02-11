using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Returns async Id.
        /// </summary>
        public async Task<ResultOrError<Result<BatchResponse<T>>>> RunBatchAsync<T>(BatchRequest<Job<T>> request) where T : new()
        {
            return await this.CallAsync<Result<BatchResponse<T>>>("batch", "run",request );
        }
    }
}
