#nullable enable

namespace Presenton
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Reset:Reset Password
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResetResetPasswordApiV1AuthResetPasswordPostAsync(

            global::Presenton.BodyResetResetPasswordApiV1AuthResetPasswordPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset:Reset Password
        /// </summary>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResetResetPasswordApiV1AuthResetPasswordPostAsync(
            string token,
            string password,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}