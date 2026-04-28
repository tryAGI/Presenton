
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyInitFixSlideApiV2PptFixSlideInitPost
    {
        /// <summary>
        /// HTML of the slide to potentially fix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Slide image (png/jpeg)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] SlideImage { get; set; }

        /// <summary>
        /// Slide image (png/jpeg)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlideImagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInitFixSlideApiV2PptFixSlideInitPost" /> class.
        /// </summary>
        /// <param name="html">
        /// HTML of the slide to potentially fix
        /// </param>
        /// <param name="slideImage">
        /// Slide image (png/jpeg)
        /// </param>
        /// <param name="slideImagename">
        /// Slide image (png/jpeg)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyInitFixSlideApiV2PptFixSlideInitPost(
            string html,
            byte[] slideImage,
            string slideImagename)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.SlideImage = slideImage ?? throw new global::System.ArgumentNullException(nameof(slideImage));
            this.SlideImagename = slideImagename ?? throw new global::System.ArgumentNullException(nameof(slideImagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInitFixSlideApiV2PptFixSlideInitPost" /> class.
        /// </summary>
        public BodyInitFixSlideApiV2PptFixSlideInitPost()
        {
        }
    }
}