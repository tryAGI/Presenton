#nullable enable

namespace Presenton
{
    public partial interface IV2FixSlideClient
    {
        /// <summary>
        /// Get Fix Html
        /// </summary>
        /// <param name="key">
        /// Slide fix task id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFixHtmlApiV2PptFixSlideFixGetAsync(
            global::System.Guid key,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Fix Html
        /// </summary>
        /// <param name="key">
        /// Slide fix task id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<string>> GetFixHtmlApiV2PptFixSlideFixGetAsResponseAsync(
            global::System.Guid key,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}