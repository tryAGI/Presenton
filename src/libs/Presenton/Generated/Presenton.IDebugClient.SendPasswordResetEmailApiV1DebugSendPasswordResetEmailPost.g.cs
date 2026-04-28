#nullable enable

namespace Presenton
{
    public partial interface IDebugClient
    {
        /// <summary>
        /// Send Password Reset Email
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task SendPasswordResetEmailApiV1DebugSendPasswordResetEmailPostAsync(

            global::Presenton.BodySendPasswordResetEmailApiV1DebugSendPasswordResetEmailPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Password Reset Email
        /// </summary>
        /// <param name="token"></param>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendPasswordResetEmailApiV1DebugSendPasswordResetEmailPostAsync(
            string token,
            string email,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}