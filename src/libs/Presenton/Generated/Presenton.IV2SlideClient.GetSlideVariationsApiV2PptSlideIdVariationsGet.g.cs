#nullable enable

namespace Presenton
{
    public partial interface IV2SlideClient
    {
        /// <summary>
        /// Get Slide Variations<br/>
        /// Return persisted HTML variations for a slide by its UUID with pagination (simple JSON, no SSE).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count">
        /// Default Value: 3
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PaginatedVariationsResponse> GetSlideVariationsApiV2PptSlideIdVariationsGetAsync(
            global::System.Guid id,
            int? count = default,
            int? page = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Slide Variations<br/>
        /// Return persisted HTML variations for a slide by its UUID with pagination (simple JSON, no SSE).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count">
        /// Default Value: 3
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PaginatedVariationsResponse>> GetSlideVariationsApiV2PptSlideIdVariationsGetAsResponseAsync(
            global::System.Guid id,
            int? count = default,
            int? page = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}