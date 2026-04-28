
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditSectionHTMLResponseV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSectionHTMLResponseV2" /> class.
        /// </summary>
        /// <param name="html"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditSectionHTMLResponseV2(
            string html)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSectionHTMLResponseV2" /> class.
        /// </summary>
        public EditSectionHTMLResponseV2()
        {
        }
    }
}