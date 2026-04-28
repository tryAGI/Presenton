#nullable enable

namespace Presenton
{
    public partial interface IV2PresentationClient
    {
        /// <summary>
        /// Generate Html Presentation V2<br/>
        /// Create and store presentation; return its id. No SSE or generation here.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GenerateHTMLPresentationResponseV2> GenerateHtmlPresentationV2ApiV2PptPresentationGenerateHtmlInitPostAsync(

            global::Presenton.GenerateHTMLPresentationRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Html Presentation V2<br/>
        /// Create and store presentation; return its id. No SSE or generation here.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="nSlides"></param>
        /// <param name="language"></param>
        /// <param name="tone">
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// Default Value: standard
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="webSearch">
        /// Default Value: false
        /// </param>
        /// <param name="designId"></param>
        /// <param name="imageType">
        /// Default Value: ai-generated
        /// </param>
        /// <param name="filePaths"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GenerateHTMLPresentationResponseV2> GenerateHtmlPresentationV2ApiV2PptPresentationGenerateHtmlInitPostAsync(
            global::System.Guid designId,
            string? content = default,
            int? nSlides = default,
            string? language = default,
            global::Presenton.Tone? tone = default,
            global::Presenton.Verbosity? verbosity = default,
            string? instructions = default,
            bool? webSearch = default,
            global::Presenton.GenerateHTMLPresentationRequestV2ImageType? imageType = default,
            global::System.Collections.Generic.IList<string>? filePaths = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}