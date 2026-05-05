#nullable enable

namespace Presenton
{
    public partial interface IV2PresentationClient
    {
        /// <summary>
        /// Generate Presentation Async V2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync(

            global::Presenton.GeneratePresentationRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Presentation Async V2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncTaskModel>> GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsResponseAsync(

            global::Presenton.GeneratePresentationRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Presentation Async V2
        /// </summary>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="slides">
        /// The content for the each slide
        /// </param>
        /// <param name="nSlides">
        /// Number of slides to generate
        /// </param>
        /// <param name="instructions">
        /// The instruction for generating the presentation
        /// </param>
        /// <param name="tone">
        /// The tone to use for the text<br/>
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// How verbose the text should be<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="contentGeneration">
        /// How to generate the content for each slide
        /// </param>
        /// <param name="smartDesign">
        /// Smart design to use for the presentation
        /// </param>
        /// <param name="markdownEmphasis">
        /// Whether to emphasize the markdown<br/>
        /// Default Value: true
        /// </param>
        /// <param name="webSearch">
        /// Whether to enable web search<br/>
        /// Default Value: false
        /// </param>
        /// <param name="imageType">
        /// Type of image to generate<br/>
        /// Default Value: stock
        /// </param>
        /// <param name="language">
        /// Language for the presentation
        /// </param>
        /// <param name="includeTableOfContents">
        /// Whether to include a table of contents<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTitleSlide">
        /// Whether to include a title slide<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAccessToUserInfo">
        /// Whether to allow access to user's info<br/>
        /// Default Value: true
        /// </param>
        /// <param name="files">
        /// Files to use for the presentation. Use /api/v1/ppt/files/upload to upload files.
        /// </param>
        /// <param name="exportAs">
        /// Export format<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="triggerWebhook">
        /// Whether to trigger subscribed webhooks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync(
            string smartDesign,
            string? content = default,
            global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>? slides = default,
            int? nSlides = default,
            string? instructions = default,
            global::Presenton.Tone? tone = default,
            global::Presenton.Verbosity? verbosity = default,
            global::Presenton.ContentGenerationMode? contentGeneration = default,
            bool? markdownEmphasis = default,
            bool? webSearch = default,
            global::Presenton.GeneratePresentationRequestV2ImageType? imageType = default,
            string? language = default,
            bool? includeTableOfContents = default,
            bool? includeTitleSlide = default,
            bool? allowAccessToUserInfo = default,
            global::System.Collections.Generic.IList<string>? files = default,
            global::Presenton.GeneratePresentationRequestV2ExportAs? exportAs = default,
            bool? triggerWebhook = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}