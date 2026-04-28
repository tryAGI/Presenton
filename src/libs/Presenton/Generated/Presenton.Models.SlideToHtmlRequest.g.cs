
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlideToHtmlRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("xml")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Xml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        public global::System.Collections.Generic.IList<string>? Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideToHtmlRequest" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="xml"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlideToHtmlRequest(
            string image,
            string xml,
            global::System.Collections.Generic.IList<string>? fonts)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Xml = xml ?? throw new global::System.ArgumentNullException(nameof(xml));
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideToHtmlRequest" /> class.
        /// </summary>
        public SlideToHtmlRequest()
        {
        }
    }
}