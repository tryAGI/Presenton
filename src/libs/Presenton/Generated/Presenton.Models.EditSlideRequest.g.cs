
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditSlideRequest
    {
        /// <summary>
        /// The id of the slide to edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The id of the presentation to edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        public global::System.Guid? PresentationId { get; set; }

        /// <summary>
        /// The index of the slide to edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_index")]
        public int? SlideIndex { get; set; }

        /// <summary>
        /// The prompt to edit the slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        public global::Presenton.EditSlideRequestExportAs2? ExportAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to edit the slide
        /// </param>
        /// <param name="id">
        /// The id of the slide to edit
        /// </param>
        /// <param name="presentationId">
        /// The id of the presentation to edit
        /// </param>
        /// <param name="slideIndex">
        /// The index of the slide to edit
        /// </param>
        /// <param name="exportAs">
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditSlideRequest(
            string prompt,
            global::System.Guid? id,
            global::System.Guid? presentationId,
            int? slideIndex,
            global::Presenton.EditSlideRequestExportAs2? exportAs)
        {
            this.Id = id;
            this.PresentationId = presentationId;
            this.SlideIndex = slideIndex;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ExportAs = exportAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideRequest" /> class.
        /// </summary>
        public EditSlideRequest()
        {
        }
    }
}