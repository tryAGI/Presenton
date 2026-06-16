#nullable enable

namespace Presenton
{
    public partial interface IDownloadsClient
    {
        /// <summary>
        /// Add Download Handler
        /// </summary>
        /// <param name="device"></param>
        /// <param name="format"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddDownloadHandlerApiV3DownloadsAddPostAsync(
            global::Presenton.Device device,
            global::Presenton.DownloadFormat format,
            string version,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Download Handler
        /// </summary>
        /// <param name="device"></param>
        /// <param name="format"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<string>> AddDownloadHandlerApiV3DownloadsAddPostAsResponseAsync(
            global::Presenton.Device device,
            global::Presenton.DownloadFormat format,
            string version,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}