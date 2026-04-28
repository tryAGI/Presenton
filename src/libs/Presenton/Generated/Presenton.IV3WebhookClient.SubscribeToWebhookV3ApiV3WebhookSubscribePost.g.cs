#nullable enable

namespace Presenton
{
    public partial interface IV3WebhookClient
    {
        /// <summary>
        /// Subscribe To Webhook V3<br/>
        /// Subscribe to a webhook.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SubscribeToWebhookResponseV1> SubscribeToWebhookV3ApiV3WebhookSubscribePostAsync(

            global::Presenton.SubscribeToWebhookRequestV1 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Subscribe To Webhook V3<br/>
        /// Subscribe to a webhook.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="url">
        /// The URL to send the webhook to
        /// </param>
        /// <param name="secret">
        /// The secret to use for the webhook
        /// </param>
        /// <param name="event">
        /// The event to subscribe to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SubscribeToWebhookResponseV1> SubscribeToWebhookV3ApiV3WebhookSubscribePostAsync(
            string url,
            global::Presenton.WebhookEvent @event,
            string? secret = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}