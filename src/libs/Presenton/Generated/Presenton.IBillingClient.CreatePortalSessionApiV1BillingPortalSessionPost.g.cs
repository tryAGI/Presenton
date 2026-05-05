#nullable enable

namespace Presenton
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Create Portal Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.CreatePortalSessionResponse> CreatePortalSessionApiV1BillingPortalSessionPostAsync(

            global::Presenton.BodyCreatePortalSessionApiV1BillingPortalSessionPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Portal Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.CreatePortalSessionResponse>> CreatePortalSessionApiV1BillingPortalSessionPostAsResponseAsync(

            global::Presenton.BodyCreatePortalSessionApiV1BillingPortalSessionPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Portal Session
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.CreatePortalSessionResponse> CreatePortalSessionApiV1BillingPortalSessionPostAsync(
            string returnUrl,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}