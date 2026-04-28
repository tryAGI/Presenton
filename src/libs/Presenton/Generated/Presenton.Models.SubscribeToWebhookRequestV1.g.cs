
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscribeToWebhookRequestV1
    {
        /// <summary>
        /// The URL to send the webhook to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The secret to use for the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// The event to subscribe to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.WebhookEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.WebhookEvent Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToWebhookRequestV1" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to send the webhook to
        /// </param>
        /// <param name="event">
        /// The event to subscribe to
        /// </param>
        /// <param name="secret">
        /// The secret to use for the webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscribeToWebhookRequestV1(
            string url,
            global::Presenton.WebhookEvent @event,
            string? secret)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Secret = secret;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToWebhookRequestV1" /> class.
        /// </summary>
        public SubscribeToWebhookRequestV1()
        {
        }
    }
}