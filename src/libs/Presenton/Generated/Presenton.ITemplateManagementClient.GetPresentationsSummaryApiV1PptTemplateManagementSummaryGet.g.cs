#nullable enable

namespace Presenton
{
    public partial interface ITemplateManagementClient
    {
        /// <summary>
        /// Get all presentations with layout counts<br/>
        /// Retrieve a summary of all presentations and the number of layouts in each
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GetPresentationSummaryResponse> GetPresentationsSummaryApiV1PptTemplateManagementSummaryGetAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}