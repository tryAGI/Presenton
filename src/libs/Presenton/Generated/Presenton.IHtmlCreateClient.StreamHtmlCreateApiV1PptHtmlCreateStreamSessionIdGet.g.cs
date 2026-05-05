#nullable enable

namespace Presenton
{
    public partial interface IHtmlCreateClient
    {
        /// <summary>
        /// Stream Html Create
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StreamHtmlCreateApiV1PptHtmlCreateStreamSessionIdGetAsync(
            global::System.Guid sessionId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Html Create
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<string>> StreamHtmlCreateApiV1PptHtmlCreateStreamSessionIdGetAsResponseAsync(
            global::System.Guid sessionId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}