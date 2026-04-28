
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyInitHtmlEditApiV1PptHtmlEditInitPost
    {
        /// <summary>
        /// Current UI image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_ui_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] CurrentUiImage { get; set; }

        /// <summary>
        /// Current UI image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_ui_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentUiImagename { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_images")]
        public global::System.Collections.Generic.IList<byte[]>? AdditionalImages { get; set; }

        /// <summary>
        /// Current HTML content to edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Text prompt describing the changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Template identifier (any string) whose design system should guide edits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInitHtmlEditApiV1PptHtmlEditInitPost" /> class.
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file
        /// </param>
        /// <param name="html">
        /// Current HTML content to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="additionalImages"></param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide edits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyInitHtmlEditApiV1PptHtmlEditInitPost(
            byte[] currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            byte[]? sketchImage,
            string? sketchImagename,
            global::System.Collections.Generic.IList<byte[]>? additionalImages,
            string? templateId)
        {
            this.CurrentUiImage = currentUiImage ?? throw new global::System.ArgumentNullException(nameof(currentUiImage));
            this.CurrentUiImagename = currentUiImagename ?? throw new global::System.ArgumentNullException(nameof(currentUiImagename));
            this.SketchImage = sketchImage;
            this.SketchImagename = sketchImagename;
            this.AdditionalImages = additionalImages;
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.TemplateId = templateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInitHtmlEditApiV1PptHtmlEditInitPost" /> class.
        /// </summary>
        public BodyInitHtmlEditApiV1PptHtmlEditInitPost()
        {
        }
    }
}