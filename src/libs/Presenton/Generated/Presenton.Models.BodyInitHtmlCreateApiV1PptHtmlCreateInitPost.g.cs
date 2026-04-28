
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyInitHtmlCreateApiV1PptHtmlCreateInitPost
    {
        /// <summary>
        /// Primary reference/sketch image (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_image")]
        public byte[]? SketchImage { get; set; }

        /// <summary>
        /// Primary reference/sketch image (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_imagename")]
        public string? SketchImagename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_images")]
        public global::System.Collections.Generic.IList<byte[]>? AdditionalImages { get; set; }

        /// <summary>
        /// Optional existing HTML content to inform create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Text prompt describing the slide to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Template identifier (any string) whose design system should guide create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInitHtmlCreateApiV1PptHtmlCreateInitPost" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt describing the slide to create
        /// </param>
        /// <param name="sketchImage">
        /// Primary reference/sketch image (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Primary reference/sketch image (optional)
        /// </param>
        /// <param name="additionalImages"></param>
        /// <param name="html">
        /// Optional existing HTML content to inform create
        /// </param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyInitHtmlCreateApiV1PptHtmlCreateInitPost(
            string prompt,
            byte[]? sketchImage,
            string? sketchImagename,
            global::System.Collections.Generic.IList<byte[]>? additionalImages,
            string? html,
            string? templateId)
        {
            this.SketchImage = sketchImage;
            this.SketchImagename = sketchImagename;
            this.AdditionalImages = additionalImages;
            this.Html = html;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.TemplateId = templateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInitHtmlCreateApiV1PptHtmlCreateInitPost" /> class.
        /// </summary>
        public BodyInitHtmlCreateApiV1PptHtmlCreateInitPost()
        {
        }
    }
}