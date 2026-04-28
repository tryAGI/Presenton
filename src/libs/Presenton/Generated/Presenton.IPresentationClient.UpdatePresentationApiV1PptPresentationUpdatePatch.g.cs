#nullable enable

namespace Presenton
{
    public partial interface IPresentationClient
    {
        /// <summary>
        /// Update Presentation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationWithSlidesV1> UpdatePresentationApiV1PptPresentationUpdatePatchAsync(

            global::Presenton.BodyUpdatePresentationApiV1PptPresentationUpdatePatch request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Presentation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nSlides"></param>
        /// <param name="title"></param>
        /// <param name="theme"></param>
        /// <param name="slides"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationWithSlidesV1> UpdatePresentationApiV1PptPresentationUpdatePatchAsync(
            global::System.Guid id,
            int? nSlides = default,
            string? title = default,
            object? theme = default,
            global::System.Collections.Generic.IList<global::Presenton.SlideModel>? slides = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}