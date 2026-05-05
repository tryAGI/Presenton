#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// Delete Enterprise User Access Token
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEnterpriseUserAccessTokenApiV3EnterpriseUsersUserIdAccessTokensTokenDeleteAsync(
            global::System.Guid userId,
            string token,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Enterprise User Access Token
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse> DeleteEnterpriseUserAccessTokenApiV3EnterpriseUsersUserIdAccessTokensTokenDeleteAsResponseAsync(
            global::System.Guid userId,
            string token,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}