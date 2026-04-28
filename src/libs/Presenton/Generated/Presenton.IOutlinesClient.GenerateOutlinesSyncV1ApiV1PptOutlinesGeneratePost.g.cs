#nullable enable

namespace Presenton
{
    public partial interface IOutlinesClient
    {
        /// <summary>
        /// Generate Outlines Sync V1
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GenerateOutlinesSyncV1ApiV1PptOutlinesGeneratePostAsync(

            global::Presenton.GenerateOutlinesRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Outlines Sync V1
        /// </summary>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="files">
        /// The files to use for the presentation
        /// </param>
        /// <param name="nSlides">
        /// The number of slides to generate
        /// </param>
        /// <param name="language">
        /// The language for the presentation
        /// </param>
        /// <param name="tone">
        /// The tone for the presentation<br/>
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// The verbosity for the presentation<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="contentGeneration">
        /// The content generation mode for the presentation
        /// </param>
        /// <param name="includeTitleSlide">
        /// Whether to include a title slide<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAccessToUserInfo">
        /// Whether to allow access to user's info<br/>
        /// Default Value: true
        /// </param>
        /// <param name="instructions">
        /// The instructions for the presentation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GenerateOutlinesSyncV1ApiV1PptOutlinesGeneratePostAsync(
            string? content = default,
            global::System.Collections.Generic.IList<string>? files = default,
            int? nSlides = default,
            string? language = default,
            global::Presenton.Tone? tone = default,
            global::Presenton.Verbosity? verbosity = default,
            global::Presenton.ContentGenerationMode? contentGeneration = default,
            bool? includeTitleSlide = default,
            bool? allowAccessToUserInfo = default,
            string? instructions = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}