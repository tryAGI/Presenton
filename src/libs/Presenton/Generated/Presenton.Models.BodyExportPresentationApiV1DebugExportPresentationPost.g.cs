
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyExportPresentationApiV1DebugExportPresentationPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.BodyExportPresentationApiV1DebugExportPresentationPostExportAsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.BodyExportPresentationApiV1DebugExportPresentationPostExportAs ExportAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportPresentationApiV1DebugExportPresentationPost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="presentationId"></param>
        /// <param name="exportAs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyExportPresentationApiV1DebugExportPresentationPost(
            string token,
            global::System.Guid presentationId,
            global::Presenton.BodyExportPresentationApiV1DebugExportPresentationPostExportAs exportAs)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.PresentationId = presentationId;
            this.ExportAs = exportAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportPresentationApiV1DebugExportPresentationPost" /> class.
        /// </summary>
        public BodyExportPresentationApiV1DebugExportPresentationPost()
        {
        }

    }
}