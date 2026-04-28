
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlideData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SlideNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshot_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScreenshotUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xml_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XmlContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NormalizedFonts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_content")]
        public string? MarkdownContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideData" /> class.
        /// </summary>
        /// <param name="slideNumber"></param>
        /// <param name="screenshotUrl"></param>
        /// <param name="xmlContent"></param>
        /// <param name="normalizedFonts"></param>
        /// <param name="markdownContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlideData(
            int slideNumber,
            string screenshotUrl,
            string xmlContent,
            global::System.Collections.Generic.IList<string> normalizedFonts,
            string? markdownContent)
        {
            this.SlideNumber = slideNumber;
            this.ScreenshotUrl = screenshotUrl ?? throw new global::System.ArgumentNullException(nameof(screenshotUrl));
            this.XmlContent = xmlContent ?? throw new global::System.ArgumentNullException(nameof(xmlContent));
            this.NormalizedFonts = normalizedFonts ?? throw new global::System.ArgumentNullException(nameof(normalizedFonts));
            this.MarkdownContent = markdownContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideData" /> class.
        /// </summary>
        public SlideData()
        {
        }
    }
}