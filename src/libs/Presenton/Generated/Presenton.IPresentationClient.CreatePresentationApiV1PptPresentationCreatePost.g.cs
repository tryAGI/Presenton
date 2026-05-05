#nullable enable

namespace Presenton
{
    public partial interface IPresentationClient
    {
        /// <summary>
        /// Create Presentation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationModel> CreatePresentationApiV1PptPresentationCreatePostAsync(

            global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Presentation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PresentationModel>> CreatePresentationApiV1PptPresentationCreatePostAsResponseAsync(

            global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Presentation
        /// </summary>
        /// <param name="content"></param>
        /// <param name="nSlides"></param>
        /// <param name="language"></param>
        /// <param name="filePaths"></param>
        /// <param name="tone">
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// Default Value: standard
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="includeTableOfContents">
        /// Default Value: false
        /// </param>
        /// <param name="includeTitleSlide">
        /// Default Value: true
        /// </param>
        /// <param name="webSearch">
        /// Default Value: false
        /// </param>
        /// <param name="imageType">
        /// Default Value: stock
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationModel> CreatePresentationApiV1PptPresentationCreatePostAsync(
            string? content = default,
            int? nSlides = default,
            string? language = default,
            global::System.Collections.Generic.IList<string>? filePaths = default,
            global::Presenton.Tone? tone = default,
            global::Presenton.Verbosity? verbosity = default,
            string? instructions = default,
            bool? includeTableOfContents = default,
            bool? includeTitleSlide = default,
            bool? webSearch = default,
            global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePostImageType? imageType = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}