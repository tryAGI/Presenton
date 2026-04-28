#nullable enable

namespace Presenton
{
    public partial interface IDownloadsClient
    {
        /// <summary>
        /// Add Download
        /// </summary>
        /// <param name="device"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddDownloadApiV3DownloadsAddPostAsync(
            global::Presenton.Device device,
            global::Presenton.DownloadFormat format,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}