#nullable enable

namespace Presenton
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Modify Subscription
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ModifySubscriptionResponse> ModifySubscriptionApiV1BillingSubscriptionModifyPostAsync(

            global::Presenton.BodyModifySubscriptionApiV1BillingSubscriptionModifyPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Subscription
        /// </summary>
        /// <param name="priceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ModifySubscriptionResponse> ModifySubscriptionApiV1BillingSubscriptionModifyPostAsync(
            string priceId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}