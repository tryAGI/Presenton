#nullable enable

namespace Presenton
{
    public partial interface IDebugClient
    {
        /// <summary>
        /// Get Jwt Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GetJwtTokenResponse> GetJwtTokenApiV1DebugGetJwtTokenPostAsync(

            global::Presenton.BodyGetJwtTokenApiV1DebugGetJwtTokenPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Jwt Token
        /// </summary>
        /// <param name="user"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GetJwtTokenResponse> GetJwtTokenApiV1DebugGetJwtTokenPostAsync(
            global::System.Guid user,
            string token,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}