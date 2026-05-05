#nullable enable

namespace Presenton
{
    public partial interface IV2SlideClient
    {
        /// <summary>
        /// Stream Slide Variations<br/>
        /// SSE: Stream HTML variations for a slide by its UUID, matching legacy format, and persist after generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count">
        /// Default Value: 3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StreamSlideVariationsApiV2PptSlideIdVariationsGenerateGetAsync(
            global::System.Guid id,
            int? count = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Slide Variations<br/>
        /// SSE: Stream HTML variations for a slide by its UUID, matching legacy format, and persist after generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count">
        /// Default Value: 3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<string>> StreamSlideVariationsApiV2PptSlideIdVariationsGenerateGetAsResponseAsync(
            global::System.Guid id,
            int? count = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}