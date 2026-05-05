#nullable enable

namespace Presenton
{
    public partial interface IWebhookClient
    {
        /// <summary>
        /// Unsubscribe To Webhook V1<br/>
        /// Unsubscribe from a webhook.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task UnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDeleteAsync(

            global::Presenton.BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unsubscribe To Webhook V1<br/>
        /// Unsubscribe from a webhook.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse> UnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDeleteAsResponseAsync(

            global::Presenton.BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unsubscribe To Webhook V1<br/>
        /// Unsubscribe from a webhook.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook subscription to unsubscribe from
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDeleteAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}