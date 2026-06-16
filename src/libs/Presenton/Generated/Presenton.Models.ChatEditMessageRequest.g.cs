
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEditMessageRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.ChatEditMessageRequestPresentationTypeJsonConverter))]
        public global::Presenton.ChatEditMessageRequestPresentationType? PresentationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public global::System.Guid? MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEditMessageRequest" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="conversationId"></param>
        /// <param name="message"></param>
        /// <param name="presentationType">
        /// Default Value: standard
        /// </param>
        /// <param name="messageId"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEditMessageRequest(
            global::System.Guid presentationId,
            global::System.Guid conversationId,
            string message,
            global::Presenton.ChatEditMessageRequestPresentationType? presentationType,
            global::System.Guid? messageId,
            int? position)
        {
            this.PresentationId = presentationId;
            this.PresentationType = presentationType;
            this.ConversationId = conversationId;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.MessageId = messageId;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEditMessageRequest" /> class.
        /// </summary>
        public ChatEditMessageRequest()
        {
        }

    }
}