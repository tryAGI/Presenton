
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FontsUploadAndSlidesPreviewResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SlideImageUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PptxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_pptx_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedPptxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FontsUploadAndSlidesPreviewResponse" /> class.
        /// </summary>
        /// <param name="slideImageUrls"></param>
        /// <param name="pptxUrl"></param>
        /// <param name="modifiedPptxUrl"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FontsUploadAndSlidesPreviewResponse(
            global::System.Collections.Generic.IList<string> slideImageUrls,
            string pptxUrl,
            string modifiedPptxUrl,
            object fonts)
        {
            this.SlideImageUrls = slideImageUrls ?? throw new global::System.ArgumentNullException(nameof(slideImageUrls));
            this.PptxUrl = pptxUrl ?? throw new global::System.ArgumentNullException(nameof(pptxUrl));
            this.ModifiedPptxUrl = modifiedPptxUrl ?? throw new global::System.ArgumentNullException(nameof(modifiedPptxUrl));
            this.Fonts = fonts ?? throw new global::System.ArgumentNullException(nameof(fonts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FontsUploadAndSlidesPreviewResponse" /> class.
        /// </summary>
        public FontsUploadAndSlidesPreviewResponse()
        {
        }
    }
}