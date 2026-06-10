
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.ChatMessageRequestPresentationTypeJsonConverter))]
        public global::Presenton.ChatMessageRequestPresentationType? PresentationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public global::System.Guid? ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageRequest" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="message"></param>
        /// <param name="presentationType">
        /// Default Value: standard
        /// </param>
        /// <param name="conversationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessageRequest(
            global::System.Guid presentationId,
            string message,
            global::Presenton.ChatMessageRequestPresentationType? presentationType,
            global::System.Guid? conversationId)
        {
            this.PresentationId = presentationId;
            this.PresentationType = presentationType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageRequest" /> class.
        /// </summary>
        public ChatMessageRequest()
        {
        }

    }
}