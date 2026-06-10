
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatHistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.ChatHistoryResponsePresentationTypeJsonConverter))]
        public global::Presenton.ChatHistoryResponsePresentationType? PresentationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.ChatHistoryMessageItem> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatHistoryResponse" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messages"></param>
        /// <param name="presentationType">
        /// Default Value: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatHistoryResponse(
            global::System.Guid presentationId,
            global::System.Guid conversationId,
            global::System.Collections.Generic.IList<global::Presenton.ChatHistoryMessageItem> messages,
            global::Presenton.ChatHistoryResponsePresentationType? presentationType)
        {
            this.PresentationId = presentationId;
            this.PresentationType = presentationType;
            this.ConversationId = conversationId;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatHistoryResponse" /> class.
        /// </summary>
        public ChatHistoryResponse()
        {
        }

    }
}