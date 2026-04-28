
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPresentationExportApiV2OnPresentationExportPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.BodyPresentationExportApiV2OnPresentationExportPostExportAsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.BodyPresentationExportApiV2OnPresentationExportPostExportAs ExportAs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPresentationExportApiV2OnPresentationExportPost" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="exportAs"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyPresentationExportApiV2OnPresentationExportPost(
            global::System.Guid presentationId,
            global::Presenton.BodyPresentationExportApiV2OnPresentationExportPostExportAs exportAs,
            string url)
        {
            this.PresentationId = presentationId;
            this.ExportAs = exportAs;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPresentationExportApiV2OnPresentationExportPost" /> class.
        /// </summary>
        public BodyPresentationExportApiV2OnPresentationExportPost()
        {
        }
    }
}