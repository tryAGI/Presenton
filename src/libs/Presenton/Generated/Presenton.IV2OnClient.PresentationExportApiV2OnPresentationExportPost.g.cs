#nullable enable

namespace Presenton
{
    public partial interface IV2OnClient
    {
        /// <summary>
        /// Presentation Export
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PresentationExportApiV2OnPresentationExportPostAsync(

            global::Presenton.BodyPresentationExportApiV2OnPresentationExportPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Presentation Export
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="exportAs"></param>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PresentationExportApiV2OnPresentationExportPostAsync(
            global::System.Guid presentationId,
            global::Presenton.BodyPresentationExportApiV2OnPresentationExportPostExportAs exportAs,
            string url,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}