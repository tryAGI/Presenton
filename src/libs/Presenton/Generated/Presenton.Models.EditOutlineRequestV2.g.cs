
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditOutlineRequestV2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("outlines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Outlines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditOutlineRequestV2" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="outlines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditOutlineRequestV2(
            global::System.Guid presentationId,
            global::System.Collections.Generic.IList<string> outlines)
        {
            this.PresentationId = presentationId;
            this.Outlines = outlines ?? throw new global::System.ArgumentNullException(nameof(outlines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditOutlineRequestV2" /> class.
        /// </summary>
        public EditOutlineRequestV2()
        {
        }
    }
}