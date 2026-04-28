#nullable enable

namespace Presenton
{
    public partial interface IV3WebhookClient
    {
        /// <summary>
        /// Unsubscribe All Webhook Subscriptions V3<br/>
        /// Unsubscribe from all webhook subscriptions of the user.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task UnsubscribeAllWebhookSubscriptionsV3ApiV3WebhookUnsubscribeAllDeleteAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}