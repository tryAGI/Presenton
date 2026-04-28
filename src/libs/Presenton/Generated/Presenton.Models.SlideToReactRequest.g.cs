
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlideToReactRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MarkdownContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DesignSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        public global::System.Collections.Generic.IList<string>? Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideToReactRequest" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="markdownContent"></param>
        /// <param name="designSystem"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlideToReactRequest(
            string image,
            string markdownContent,
            object designSystem,
            global::System.Collections.Generic.IList<string>? fonts)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.MarkdownContent = markdownContent ?? throw new global::System.ArgumentNullException(nameof(markdownContent));
            this.DesignSystem = designSystem ?? throw new global::System.ArgumentNullException(nameof(designSystem));
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideToReactRequest" /> class.
        /// </summary>
        public SlideToReactRequest()
        {
        }
    }
}