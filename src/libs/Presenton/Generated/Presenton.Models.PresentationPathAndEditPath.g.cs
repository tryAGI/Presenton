
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentationPathAndEditPath
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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EditPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_consumed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditsConsumed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationPathAndEditPath" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="path"></param>
        /// <param name="editPath"></param>
        /// <param name="creditsConsumed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentationPathAndEditPath(
            global::System.Guid presentationId,
            string path,
            string editPath,
            double creditsConsumed)
        {
            this.PresentationId = presentationId;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.EditPath = editPath ?? throw new global::System.ArgumentNullException(nameof(editPath));
            this.CreditsConsumed = creditsConsumed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationPathAndEditPath" /> class.
        /// </summary>
        public PresentationPathAndEditPath()
        {
        }
    }
}