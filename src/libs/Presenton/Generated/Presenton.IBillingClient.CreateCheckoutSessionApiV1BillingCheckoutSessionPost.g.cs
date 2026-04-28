#nullable enable

namespace Presenton
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Create Checkout Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.CreateCheckoutSessionResponse> CreateCheckoutSessionApiV1BillingCheckoutSessionPostAsync(

            global::Presenton.CreateCheckoutSessionRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Checkout Session
        /// </summary>
        /// <param name="priceId"></param>
        /// <param name="mode">
        /// Default Value: subscription
        /// </param>
        /// <param name="quantity">
        /// Default Value: 1
        /// </param>
        /// <param name="successUrl"></param>
        /// <param name="cancelUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.CreateCheckoutSessionResponse> CreateCheckoutSessionApiV1BillingCheckoutSessionPostAsync(
            string priceId,
            string successUrl,
            string cancelUrl,
            string? mode = default,
            int? quantity = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}