
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost
    {
        /// <summary>
        /// Presentation ID to export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Format to export the presentation as
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs ExportAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost" /> class.
        /// </summary>
        /// <param name="id">
        /// Presentation ID to export
        /// </param>
        /// <param name="exportAs">
        /// Format to export the presentation as
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost(
            global::System.Guid id,
            global::Presenton.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs exportAs)
        {
            this.Id = id;
            this.ExportAs = exportAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost" /> class.
        /// </summary>
        public BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost()
        {
        }
    }
}