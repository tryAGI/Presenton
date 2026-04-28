
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSlideFromJsonRequestV1
    {
        /// <summary>
        /// The id of the slide to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The layout of the slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Layout { get; set; }

        /// <summary>
        /// The content of the slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// The speaker note of the slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_note")]
        public string? SpeakerNote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlideFromJsonRequestV1" /> class.
        /// </summary>
        /// <param name="layout">
        /// The layout of the slide
        /// </param>
        /// <param name="content">
        /// The content of the slide
        /// </param>
        /// <param name="id">
        /// The id of the slide to use
        /// </param>
        /// <param name="speakerNote">
        /// The speaker note of the slide
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSlideFromJsonRequestV1(
            string layout,
            object content,
            global::System.Guid? id,
            string? speakerNote)
        {
            this.Id = id;
            this.Layout = layout ?? throw new global::System.ArgumentNullException(nameof(layout));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.SpeakerNote = speakerNote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlideFromJsonRequestV1" /> class.
        /// </summary>
        public CreateSlideFromJsonRequestV1()
        {
        }
    }
}