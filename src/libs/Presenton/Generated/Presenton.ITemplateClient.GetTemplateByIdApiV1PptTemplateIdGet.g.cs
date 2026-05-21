#nullable enable

namespace Presenton
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Get Template By Id
        /// </summary>
        /// <param name="id">
        /// The id of the template, must be one of neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift or your custom template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationLayoutModel> GetTemplateByIdApiV1PptTemplateIdGetAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Template By Id
        /// </summary>
        /// <param name="id">
        /// The id of the template, must be one of neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift or your custom template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PresentationLayoutModel>> GetTemplateByIdApiV1PptTemplateIdGetAsResponseAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}