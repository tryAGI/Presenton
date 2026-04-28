#nullable enable

namespace Presenton
{
    public partial interface IV3WebhookClient
    {
        /// <summary>
        /// Get All Webhook Subscriptions V3<br/>
        /// Get all webhook subscriptions of the user.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Presenton.SubscribeToWebhookResponseV1>> GetAllWebhookSubscriptionsV3ApiV3WebhookAllGetAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}