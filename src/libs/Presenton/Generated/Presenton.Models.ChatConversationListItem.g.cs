
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatConversationListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_message_preview")]
        public string? LastMessagePreview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatConversationListItem" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastMessagePreview"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatConversationListItem(
            global::System.Guid conversationId,
            string? updatedAt,
            string? lastMessagePreview)
        {
            this.ConversationId = conversationId;
            this.UpdatedAt = updatedAt;
            this.LastMessagePreview = lastMessagePreview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatConversationListItem" /> class.
        /// </summary>
        public ChatConversationListItem()
        {
        }

    }
}