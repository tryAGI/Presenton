
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditReactWithImageEndpointApiV1PptReactEditPost
    {
        /// <summary>
        /// Current UI image file (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_ui_image")]
        public byte[]? CurrentUiImage { get; set; }

        /// <summary>
        /// Current UI image file (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_ui_imagename")]
        public string? CurrentUiImagename { get; set; }

        /// <summary>
        /// Sketch/indication image file (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_image")]
        public byte[]? SketchImage { get; set; }

        /// <summary>
        /// Sketch/indication image file (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_imagename")]
        public string? SketchImagename { get; set; }

        /// <summary>
        /// Current React component code to edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("react")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string React { get; set; }

        /// <summary>
        /// Text prompt describing the changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional design system JSON to guide the edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_system")]
        public string? DesignSystem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditReactWithImageEndpointApiV1PptReactEditPost" /> class.
        /// </summary>
        /// <param name="react">
        /// Current React component code to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="currentUiImage">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="designSystem">
        /// Optional design system JSON to guide the edit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyEditReactWithImageEndpointApiV1PptReactEditPost(
            string react,
            string prompt,
            byte[]? currentUiImage,
            string? currentUiImagename,
            byte[]? sketchImage,
            string? sketchImagename,
            string? designSystem)
        {
            this.CurrentUiImage = currentUiImage;
            this.CurrentUiImagename = currentUiImagename;
            this.SketchImage = sketchImage;
            this.SketchImagename = sketchImagename;
            this.React = react ?? throw new global::System.ArgumentNullException(nameof(react));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.DesignSystem = designSystem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditReactWithImageEndpointApiV1PptReactEditPost" /> class.
        /// </summary>
        public BodyEditReactWithImageEndpointApiV1PptReactEditPost()
        {
        }
    }
}