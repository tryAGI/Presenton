#nullable enable

namespace Presenton
{
    public partial interface IDebugClient
    {
        /// <summary>
        /// Add Credits
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task AddCreditsApiV1DebugAddCreditsPostAsync(

            global::Presenton.BodyAddCreditsApiV1DebugAddCreditsPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Credits
        /// </summary>
        /// <param name="token"></param>
        /// <param name="credits"></param>
        /// <param name="user"></param>
        /// <param name="expiresAt"></param>
        /// <param name="transactionName"></param>
        /// <param name="transactionDescription"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddCreditsApiV1DebugAddCreditsPostAsync(
            string token,
            int credits,
            global::System.Guid user,
            global::System.DateTime expiresAt,
            string? transactionName = default,
            string? transactionDescription = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}