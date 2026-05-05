#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// List Enterprise Presentations
        /// </summary>
        /// <param name="page">
        /// Page number starting from 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of presentations per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="search">
        /// Search by presentation title or presentation id
        /// </param>
        /// <param name="enterprise">
        /// Enterprise ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterprisePresentationsResponse> ListEnterprisePresentationsApiV3EnterprisePresentationsGetAsync(
            string enterprise,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Enterprise Presentations
        /// </summary>
        /// <param name="page">
        /// Page number starting from 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of presentations per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="search">
        /// Search by presentation title or presentation id
        /// </param>
        /// <param name="enterprise">
        /// Enterprise ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.EnterprisePresentationsResponse>> ListEnterprisePresentationsApiV3EnterprisePresentationsGetAsResponseAsync(
            string enterprise,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}