
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLayoutsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.LayoutData> Layouts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public object? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>))]
        public global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>? Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLayoutsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="layouts"></param>
        /// <param name="message"></param>
        /// <param name="template"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLayoutsResponse(
            bool success,
            global::System.Collections.Generic.IList<global::Presenton.LayoutData> layouts,
            string? message,
            object? template,
            global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>? fonts)
        {
            this.Success = success;
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
            this.Message = message;
            this.Template = template;
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLayoutsResponse" /> class.
        /// </summary>
        public GetLayoutsResponse()
        {
        }
    }
}