
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDesignSystemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_url")]
        public string? PptxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SlideImageUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        public object? Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDesignSystemRequest" /> class.
        /// </summary>
        /// <param name="slideImageUrls"></param>
        /// <param name="pptxUrl"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDesignSystemRequest(
            global::System.Collections.Generic.IList<string> slideImageUrls,
            string? pptxUrl,
            object? fonts)
        {
            this.PptxUrl = pptxUrl;
            this.SlideImageUrls = slideImageUrls ?? throw new global::System.ArgumentNullException(nameof(slideImageUrls));
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDesignSystemRequest" /> class.
        /// </summary>
        public CreateDesignSystemRequest()
        {
        }
    }
}