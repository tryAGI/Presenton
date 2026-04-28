#nullable enable

namespace Presenton
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Save Slide Layout
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SaveSlideLayoutApiV1PptTemplateSlideLayoutSavePostAsync(

            global::Presenton.SaveSlideLayoutRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Slide Layout
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="layoutId"></param>
        /// <param name="layoutCode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SaveSlideLayoutApiV1PptTemplateSlideLayoutSavePostAsync(
            global::System.Guid templateId,
            string layoutId,
            string layoutCode,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}