#nullable enable

namespace Presenton
{
    public partial interface IV3WebhookClient
    {
        /// <summary>
        /// Unsubscribe To Webhook V3<br/>
        /// Unsubscribe from a webhook.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task UnsubscribeToWebhookV3ApiV3WebhookUnsubscribeDeleteAsync(

            global::Presenton.BodyUnsubscribeToWebhookV3ApiV3WebhookUnsubscribeDelete request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unsubscribe To Webhook V3<br/>
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
        global::System.Threading.Tasks.Task UnsubscribeToWebhookV3ApiV3WebhookUnsubscribeDeleteAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}