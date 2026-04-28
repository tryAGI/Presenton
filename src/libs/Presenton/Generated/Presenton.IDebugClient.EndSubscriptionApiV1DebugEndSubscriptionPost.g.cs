#nullable enable

namespace Presenton
{
    public partial interface IDebugClient
    {
        /// <summary>
        /// End Subscription
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task EndSubscriptionApiV1DebugEndSubscriptionPostAsync(

            global::Presenton.BodyEndSubscriptionApiV1DebugEndSubscriptionPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End Subscription
        /// </summary>
        /// <param name="token"></param>
        /// <param name="user"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EndSubscriptionApiV1DebugEndSubscriptionPostAsync(
            string token,
            global::System.Guid user,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}