
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PdfSlideData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_content")]
        public string? MarkdownContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSlideData" /> class.
        /// </summary>
        /// <param name="slideNumber"></param>
        /// <param name="screenshotUrl"></param>
        /// <param name="markdownContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PdfSlideData(
            int slideNumber,
            string screenshotUrl,
            string? markdownContent)
        {
            this.SlideNumber = slideNumber;
            this.ScreenshotUrl = screenshotUrl ?? throw new global::System.ArgumentNullException(nameof(screenshotUrl));
            this.MarkdownContent = markdownContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSlideData" /> class.
        /// </summary>
        public PdfSlideData()
        {
        }
    }
}