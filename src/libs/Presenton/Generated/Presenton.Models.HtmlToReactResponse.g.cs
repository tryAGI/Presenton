
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HtmlToReactResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("react_component")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactComponent { get; set; }

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
        /// Initializes a new instance of the <see cref="HtmlToReactResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="reactComponent"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HtmlToReactResponse(
            bool success,
            string reactComponent,
            string? message)
        {
            this.Success = success;
            this.ReactComponent = reactComponent ?? throw new global::System.ArgumentNullException(nameof(reactComponent));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlToReactResponse" /> class.
        /// </summary>
        public HtmlToReactResponse()
        {
        }
    }
}