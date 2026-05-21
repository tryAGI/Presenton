#nullable enable

namespace Presenton
{
    public partial interface IPresentationClient
    {
        /// <summary>
        /// Check Async Presentation Generation Status<br/>
        /// Check the status of a presentation being generated asynchronously.<br/>
        /// Use /api/v1/ppt/presentation/status/task-xxxxxxxxxx to get the status of presentation.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id">
        /// ID of the presentation generation task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> CheckAsyncPresentationGenerationStatusApiV1PptPresentationStatusIdGetAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Async Presentation Generation Status<br/>
        /// Check the status of a presentation being generated asynchronously.<br/>
        /// Use /api/v1/ppt/presentation/status/task-xxxxxxxxxx to get the status of presentation.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id">
        /// ID of the presentation generation task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncTaskModel>> CheckAsyncPresentationGenerationStatusApiV1PptPresentationStatusIdGetAsResponseAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}