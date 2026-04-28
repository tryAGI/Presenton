
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlideContentLayout
    {
        /// <summary>
        /// The content for the slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The layout for the slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        public string? Layout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideContentLayout" /> class.
        /// </summary>
        /// <param name="content">
        /// The content for the slide
        /// </param>
        /// <param name="layout">
        /// The layout for the slide
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlideContentLayout(
            string content,
            string? layout)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Layout = layout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideContentLayout" /> class.
        /// </summary>
        public SlideContentLayout()
        {
        }
    }
}