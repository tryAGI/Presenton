#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// Get Enterprise User Credits Info
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterpriseUserCreditsInfoResponse> GetEnterpriseUserCreditsInfoApiV3EnterpriseUsersUserIdCreditsInfoGetAsync(
            global::System.Guid userId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Enterprise User Credits Info
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.EnterpriseUserCreditsInfoResponse>> GetEnterpriseUserCreditsInfoApiV3EnterpriseUsersUserIdCreditsInfoGetAsResponseAsync(
            global::System.Guid userId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}