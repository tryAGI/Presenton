
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HtmlEditResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edited_html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EditedHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEditResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="editedHtml"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HtmlEditResponse(
            bool success,
            string editedHtml,
            string? message)
        {
            this.Success = success;
            this.EditedHtml = editedHtml ?? throw new global::System.ArgumentNullException(nameof(editedHtml));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEditResponse" /> class.
        /// </summary>
        public HtmlEditResponse()
        {
        }
    }
}