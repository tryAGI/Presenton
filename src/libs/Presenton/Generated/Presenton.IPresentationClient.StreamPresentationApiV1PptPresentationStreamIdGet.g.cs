#nullable enable

namespace Presenton
{
    public partial interface IPresentationClient
    {
        /// <summary>
        /// Stream Presentation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationWithSlidesV1> StreamPresentationApiV1PptPresentationStreamIdGetAsync(
            global::System.Guid id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}