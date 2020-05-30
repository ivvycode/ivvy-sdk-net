using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy.API
{
    public partial interface IApiClient
    {
        /// <summary>
        /// Runs a batch request.
        /// </summary>
        /// <param name="jobs">The list of api request jobs to run.</param>
        /// <param name="callbackUrl">The url that will receive the response of the batch request.</param>
        /// <returns></returns>
        Task<ResultOrError<Batch.RunResponse>> BatchRunAsync(List<Batch.Job> jobs, string callbackUrl);

        /// <summary>
        /// Returns the progress of a batch request.
        /// </summary>
        /// <param name="asyncId">The unique id of the batch request.</param>
        /// <returns></returns>
        Task<ResultOrError<Batch.ProgressResponse>> BatchProgressAsync(string asyncId);

        /// <summary>
        /// Restarts a batch request that has paused.
        /// </summary>
        /// <param name="asyncId">The unique id of the batch request.</param>
        /// <returns></returns>
        Task<ResultOrError<Batch.RestartResponse>> BatchRestartAsync(string asyncId);

        /// <summary>
        /// Reposts a batch request that has completed.
        /// </summary>
        /// <param name="asyncId">The unique id of the batch request.</param>
        /// <returns></returns>
        Task<ResultOrError<Batch.RepostResponse>> BatchRepostAsync(string asyncId);
    }
}