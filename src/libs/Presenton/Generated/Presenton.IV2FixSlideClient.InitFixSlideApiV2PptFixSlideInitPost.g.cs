#nullable enable

namespace Presenton
{
    public partial interface IV2FixSlideClient
    {
        /// <summary>
        /// Init Fix Slide
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InitFixSlideApiV2PptFixSlideInitPostAsync(

            global::Presenton.BodyInitFixSlideApiV2PptFixSlideInitPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Fix Slide
        /// </summary>
        /// <param name="html">
        /// HTML of the slide to potentially fix
        /// </param>
        /// <param name="slideImage">
        /// Slide image (png/jpeg)
        /// </param>
        /// <param name="slideImagename">
        /// Slide image (png/jpeg)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> InitFixSlideApiV2PptFixSlideInitPostAsync(
            string html,
            byte[] slideImage,
            string slideImagename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}