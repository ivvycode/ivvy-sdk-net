using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <inheritdoc />
        public async Task<ResultOrError<Batch.RunResponse>> BatchRunAsync(List<Batch.Job> jobs, string callbackUrl)
        {
            return await this.CallAsync<Batch.RunResponse>("batch", "run", new
            {
                jobs = jobs,
                callbackUrl = callbackUrl
            });
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Batch.ProgressResponse>> BatchProgressAsync(string asyncId)
        {
            return await this.CallAsync<Batch.ProgressResponse>("batch", "progress", new
            {
                async = asyncId
            });
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Batch.RestartResponse>> BatchRestartAsync(string asyncId)
        {
            return await this.CallAsync<Batch.RestartResponse>("batch", "restart", new
            {
                async = asyncId
            });
        }

        /// <inheritdoc />
        public async Task<ResultOrError<Batch.RepostResponse>> BatchRepostAsync(string asyncId)
        {
            return await this.CallAsync<Batch.RepostResponse>("batch", "repost", new
            {
                async = asyncId
            });
        }
    }
}