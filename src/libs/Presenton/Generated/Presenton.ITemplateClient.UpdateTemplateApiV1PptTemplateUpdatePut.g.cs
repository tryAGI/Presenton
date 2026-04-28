#nullable enable

namespace Presenton
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Update Template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SaveTemplateResponse> UpdateTemplateApiV1PptTemplateUpdatePutAsync(

            global::Presenton.UpdateTemplateRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Template
        /// </summary>
        /// <param name="id"></param>
        /// <param name="layouts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SaveTemplateResponse> UpdateTemplateApiV1PptTemplateUpdatePutAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData> layouts,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}