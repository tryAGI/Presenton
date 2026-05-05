#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// List Enterprise User Presentations
        /// </summary>
        /// <param name="userId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterprisePresentationsResponse> ListEnterpriseUserPresentationsApiV3EnterpriseUsersUserIdPresentationsGetAsync(
            global::System.Guid userId,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Enterprise User Presentations
        /// </summary>
        /// <param name="userId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.EnterprisePresentationsResponse>> ListEnterpriseUserPresentationsApiV3EnterpriseUsersUserIdPresentationsGetAsResponseAsync(
            global::System.Guid userId,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}