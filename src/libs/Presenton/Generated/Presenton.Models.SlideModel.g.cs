
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlideModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Presentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_content")]
        public string? HtmlContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_note")]
        public string? SpeakerNote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideModel" /> class.
        /// </summary>
        /// <param name="presentation"></param>
        /// <param name="layoutGroup"></param>
        /// <param name="layout"></param>
        /// <param name="index"></param>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="htmlContent"></param>
        /// <param name="speakerNote"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlideModel(
            global::System.Guid presentation,
            string layoutGroup,
            string layout,
            int index,
            object content,
            global::System.Guid? id,
            string? htmlContent,
            string? speakerNote,
            object? properties)
        {
            this.Id = id;
            this.Presentation = presentation;
            this.LayoutGroup = layoutGroup ?? throw new global::System.ArgumentNullException(nameof(layoutGroup));
            this.Layout = layout ?? throw new global::System.ArgumentNullException(nameof(layout));
            this.Index = index;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.HtmlContent = htmlContent;
            this.SpeakerNote = speakerNote;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideModel" /> class.
        /// </summary>
        public SlideModel()
        {
        }
    }
}