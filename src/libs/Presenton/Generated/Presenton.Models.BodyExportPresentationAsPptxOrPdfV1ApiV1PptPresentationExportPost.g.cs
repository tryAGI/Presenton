
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost
    {
        /// <summary>
        /// Presentation ID to export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Format to export the presentation as<br/>
        /// Default Value: pptx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAsJsonConverter))]
        public global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs? ExportAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost" /> class.
        /// </summary>
        /// <param name="id">
        /// Presentation ID to export
        /// </param>
        /// <param name="exportAs">
        /// Format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost(
            global::System.Guid id,
            global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs? exportAs)
        {
            this.Id = id;
            this.ExportAs = exportAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost" /> class.
        /// </summary>
        public BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost()
        {
        }
    }
}