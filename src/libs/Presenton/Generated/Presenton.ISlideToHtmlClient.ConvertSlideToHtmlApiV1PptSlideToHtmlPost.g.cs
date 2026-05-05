#nullable enable

namespace Presenton
{
    public partial interface ISlideToHtmlClient
    {
        /// <summary>
        /// Convert Slide To Html<br/>
        /// Convert a slide image and its OXML data to HTML using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     request: JSON request containing image path and XML content<br/>
        /// Returns:<br/>
        ///     SlideToHtmlResponse with generated HTML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SlideToHtmlResponse> ConvertSlideToHtmlApiV1PptSlideToHtmlPostAsync(

            global::Presenton.SlideToHtmlRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Slide To Html<br/>
        /// Convert a slide image and its OXML data to HTML using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     request: JSON request containing image path and XML content<br/>
        /// Returns:<br/>
        ///     SlideToHtmlResponse with generated HTML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.SlideToHtmlResponse>> ConvertSlideToHtmlApiV1PptSlideToHtmlPostAsResponseAsync(

            global::Presenton.SlideToHtmlRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Slide To Html<br/>
        /// Convert a slide image and its OXML data to HTML using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     request: JSON request containing image path and XML content<br/>
        /// Returns:<br/>
        ///     SlideToHtmlResponse with generated HTML
        /// </summary>
        /// <param name="image"></param>
        /// <param name="xml"></param>
        /// <param name="fonts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SlideToHtmlResponse> ConvertSlideToHtmlApiV1PptSlideToHtmlPostAsync(
            string image,
            string xml,
            global::System.Collections.Generic.IList<string>? fonts = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}