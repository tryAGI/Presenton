
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DesignSystemSlideInput
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignSystemSlideInput" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="markdownContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesignSystemSlideInput(
            string image,
            string markdownContent)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.MarkdownContent = markdownContent ?? throw new global::System.ArgumentNullException(nameof(markdownContent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignSystemSlideInput" /> class.
        /// </summary>
        public DesignSystemSlideInput()
        {
        }
    }
}