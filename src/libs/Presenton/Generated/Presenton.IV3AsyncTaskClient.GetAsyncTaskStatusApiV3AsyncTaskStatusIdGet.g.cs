#nullable enable

namespace Presenton
{
    public partial interface IV3AsyncTaskClient
    {
        /// <summary>
        /// Get Async Task Status<br/>
        /// Check the status of an async task.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id">
        /// ID of the async task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GetAsyncTaskStatusApiV3AsyncTaskStatusIdGetAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}