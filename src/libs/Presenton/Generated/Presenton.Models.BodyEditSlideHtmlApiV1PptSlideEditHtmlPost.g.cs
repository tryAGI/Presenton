
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditSlideHtmlApiV1PptSlideEditHtmlPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditSlideHtmlApiV1PptSlideEditHtmlPost" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prompt"></param>
        /// <param name="html"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyEditSlideHtmlApiV1PptSlideEditHtmlPost(
            global::System.Guid id,
            string prompt,
            string? html)
        {
            this.Id = id;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Html = html;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditSlideHtmlApiV1PptSlideEditHtmlPost" /> class.
        /// </summary>
        public BodyEditSlideHtmlApiV1PptSlideEditHtmlPost()
        {
        }
    }
}