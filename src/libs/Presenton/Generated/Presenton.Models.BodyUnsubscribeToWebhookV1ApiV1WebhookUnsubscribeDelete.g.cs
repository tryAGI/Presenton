
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete
    {
        /// <summary>
        /// The ID of the webhook subscription to unsubscribe from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook subscription to unsubscribe from
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete" /> class.
        /// </summary>
        public BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete()
        {
        }
    }
}