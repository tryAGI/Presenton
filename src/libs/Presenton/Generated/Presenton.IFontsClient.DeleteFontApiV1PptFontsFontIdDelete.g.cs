#nullable enable

namespace Presenton
{
    public partial interface IFontsClient
    {
        /// <summary>
        /// Delete Font
        /// </summary>
        /// <param name="fontId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFontApiV1PptFontsFontIdDeleteAsync(
            global::System.Guid fontId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}