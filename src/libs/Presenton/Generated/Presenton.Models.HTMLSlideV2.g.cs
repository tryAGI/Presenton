
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTMLSlideV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_note")]
        public string? SpeakerNote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variations")]
        public global::System.Collections.Generic.IList<string>? Variations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qualitative_chart")]
        public string? QualitativeChart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTMLSlideV2" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="index"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="id"></param>
        /// <param name="html"></param>
        /// <param name="speakerNote"></param>
        /// <param name="variations"></param>
        /// <param name="qualitativeChart"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTMLSlideV2(
            global::System.Guid presentationId,
            int index,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Guid? id,
            string? html,
            string? speakerNote,
            global::System.Collections.Generic.IList<string>? variations,
            string? qualitativeChart)
        {
            this.Id = id;
            this.PresentationId = presentationId;
            this.Index = index;
            this.Html = html;
            this.SpeakerNote = speakerNote;
            this.Variations = variations;
            this.QualitativeChart = qualitativeChart;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTMLSlideV2" /> class.
        /// </summary>
        public HTMLSlideV2()
        {
        }
    }
}