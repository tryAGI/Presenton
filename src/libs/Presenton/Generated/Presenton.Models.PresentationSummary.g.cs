
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentationSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Presentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LayoutCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public object? Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationSummary" /> class.
        /// </summary>
        /// <param name="presentation"></param>
        /// <param name="layoutCount"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="template"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentationSummary(
            global::System.Guid presentation,
            int layoutCount,
            global::System.DateTime? lastUpdatedAt,
            object? template)
        {
            this.Presentation = presentation;
            this.LayoutCount = layoutCount;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationSummary" /> class.
        /// </summary>
        public PresentationSummary()
        {
        }
    }
}