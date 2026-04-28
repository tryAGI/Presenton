
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditPresentationRequest
    {
        /// <summary>
        /// The id of the presentation to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// The data to update the slides with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SlideContentUpdate> Slides { get; set; }

        /// <summary>
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.EditPresentationRequestExportAsJsonConverter))]
        public global::Presenton.EditPresentationRequestExportAs? ExportAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPresentationRequest" /> class.
        /// </summary>
        /// <param name="presentationId">
        /// The id of the presentation to use
        /// </param>
        /// <param name="slides">
        /// The data to update the slides with
        /// </param>
        /// <param name="exportAs">
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditPresentationRequest(
            global::System.Guid presentationId,
            global::System.Collections.Generic.IList<global::Presenton.SlideContentUpdate> slides,
            global::Presenton.EditPresentationRequestExportAs? exportAs)
        {
            this.PresentationId = presentationId;
            this.Slides = slides ?? throw new global::System.ArgumentNullException(nameof(slides));
            this.ExportAs = exportAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPresentationRequest" /> class.
        /// </summary>
        public EditPresentationRequest()
        {
        }
    }
}