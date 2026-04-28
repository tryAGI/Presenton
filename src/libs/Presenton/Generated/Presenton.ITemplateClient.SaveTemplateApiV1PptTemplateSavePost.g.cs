#nullable enable

namespace Presenton
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Save Template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SaveTemplateResponse> SaveTemplateApiV1PptTemplateSavePostAsync(

            global::Presenton.SaveTemplateRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Template
        /// </summary>
        /// <param name="templateInfoId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="layouts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SaveTemplateResponse> SaveTemplateApiV1PptTemplateSavePostAsync(
            global::System.Guid templateInfoId,
            string name,
            global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData> layouts,
            string? description = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}