#nullable enable

namespace Presenton
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Reactivate Subscription
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ReactivateSubscriptionResponse> ReactivateSubscriptionApiV1BillingSubscriptionReactivatePostAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}