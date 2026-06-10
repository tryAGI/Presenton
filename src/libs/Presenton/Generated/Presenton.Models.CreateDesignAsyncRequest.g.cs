
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDesignAsyncRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PptxUrl { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDesignAsyncRequest" /> class.
        /// </summary>
        /// <param name="pptxUrl"></param>
        /// <param name="slideImageUrls"></param>
        /// <param name="fonts"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDesignAsyncRequest(
            string pptxUrl,
            global::System.Collections.Generic.IList<string> slideImageUrls,
            object? fonts,
            string? name)
        {
            this.PptxUrl = pptxUrl ?? throw new global::System.ArgumentNullException(nameof(pptxUrl));
            this.SlideImageUrls = slideImageUrls ?? throw new global::System.ArgumentNullException(nameof(slideImageUrls));
            this.Fonts = fonts;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDesignAsyncRequest" /> class.
        /// </summary>
        public CreateDesignAsyncRequest()
        {
        }

    }
}