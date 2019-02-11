using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns async Id.
        /// </summary>
        /// <param name="request">The batch request.</param>
        /// <returns></returns>
        Task<ResultOrError<Result<BatchResponse<T>>>> RunBatchAsync<T>(BatchRequest<Job<T>> request) where T : new() ;
    }
}
