
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditSlideHTMLRequestV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SlideId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EditPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideHTMLRequestV2" /> class.
        /// </summary>
        /// <param name="slideId"></param>
        /// <param name="html"></param>
        /// <param name="editPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditSlideHTMLRequestV2(
            global::System.Guid slideId,
            string html,
            string editPrompt)
        {
            this.SlideId = slideId;
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.EditPrompt = editPrompt ?? throw new global::System.ArgumentNullException(nameof(editPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideHTMLRequestV2" /> class.
        /// </summary>
        public EditSlideHTMLRequestV2()
        {
        }
    }
}