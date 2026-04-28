#nullable enable

namespace Presenton
{
    public partial interface IPresentationClient
    {
        /// <summary>
        /// Prepare Presentation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationModel> PreparePresentationApiV1PptPresentationPreparePostAsync(

            global::Presenton.BodyPreparePresentationApiV1PptPresentationPreparePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prepare Presentation
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="outlines"></param>
        /// <param name="layout"></param>
        /// <param name="title"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationModel> PreparePresentationApiV1PptPresentationPreparePostAsync(
            global::System.Guid presentationId,
            global::System.Collections.Generic.IList<global::Presenton.SlideOutlineModel> outlines,
            global::Presenton.PresentationLayoutModel layout,
            string? title = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}