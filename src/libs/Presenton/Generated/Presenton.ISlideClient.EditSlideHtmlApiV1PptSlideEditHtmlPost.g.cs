#nullable enable

namespace Presenton
{
    public partial interface ISlideClient
    {
        /// <summary>
        /// Edit Slide Html
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SlideModel> EditSlideHtmlApiV1PptSlideEditHtmlPostAsync(

            global::Presenton.BodyEditSlideHtmlApiV1PptSlideEditHtmlPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Slide Html
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prompt"></param>
        /// <param name="html"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SlideModel> EditSlideHtmlApiV1PptSlideEditHtmlPostAsync(
            global::System.Guid id,
            string prompt,
            string? html = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}