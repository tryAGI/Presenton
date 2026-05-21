#nullable enable

namespace Presenton
{
    public partial interface IV3PresentationClient
    {
        /// <summary>
        /// Generate Presentation Async V3<br/>
        /// Generate a presentation asynchronously.<br/>
        /// Use /api/v3/async-task/status/task-xxxxxxxxxx to get the status of presentation.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GeneratePresentationAsyncV3ApiV3PresentationGenerateAsyncPostAsync(

            global::Presenton.GeneratePresentationRequestV3 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Presentation Async V3<br/>
        /// Generate a presentation asynchronously.<br/>
        /// Use /api/v3/async-task/status/task-xxxxxxxxxx to get the status of presentation.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncTaskModel>> GeneratePresentationAsyncV3ApiV3PresentationGenerateAsyncPostAsResponseAsync(

            global::Presenton.GeneratePresentationRequestV3 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Presentation Async V3<br/>
        /// Generate a presentation asynchronously.<br/>
        /// Use /api/v3/async-task/status/task-xxxxxxxxxx to get the status of presentation.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="slides">
        /// The content and layout for each slide
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
        /// <param name="theme">
        /// Theme to use for the presentation. Available themes: edge-yellow, light-rose, mint-blue, professional-blue, professional-dark and your custom themes
        /// </param>
        /// <param name="language">
        /// Language for the presentation
        /// </param>
        /// <param name="standardTemplate">
        /// Standard template to use for the presentation. Available templates: neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift and your custom templates
        /// </param>
        /// <param name="smartDesign">
        /// Smart design to use for the presentation
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
        /// Files to use for the presentation. Use /api/v3/files/upload to upload files.
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
        global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GeneratePresentationAsyncV3ApiV3PresentationGenerateAsyncPostAsync(
            string? content = default,
            global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>? slides = default,
            int? nSlides = default,
            string? instructions = default,
            global::Presenton.Tone? tone = default,
            global::Presenton.Verbosity? verbosity = default,
            global::Presenton.ContentGenerationMode? contentGeneration = default,
            bool? markdownEmphasis = default,
            bool? webSearch = default,
            global::Presenton.GeneratePresentationRequestV3ImageType? imageType = default,
            string? theme = default,
            string? language = default,
            string? standardTemplate = default,
            string? smartDesign = default,
            bool? includeTableOfContents = default,
            bool? includeTitleSlide = default,
            bool? allowAccessToUserInfo = default,
            global::System.Collections.Generic.IList<string>? files = default,
            global::Presenton.GeneratePresentationRequestV3ExportAs? exportAs = default,
            bool? triggerWebhook = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}