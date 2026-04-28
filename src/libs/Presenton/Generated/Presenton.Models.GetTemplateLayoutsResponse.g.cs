
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTemplateLayoutsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.TemplateLayoutData> Layouts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Presenton.TemplateData? Template { get; set; }

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
        /// Initializes a new instance of the <see cref="GetTemplateLayoutsResponse" /> class.
        /// </summary>
        /// <param name="layouts"></param>
        /// <param name="template"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTemplateLayoutsResponse(
            global::System.Collections.Generic.IList<global::Presenton.TemplateLayoutData> layouts,
            global::Presenton.TemplateData? template,
            global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>? fonts)
        {
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
            this.Template = template;
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTemplateLayoutsResponse" /> class.
        /// </summary>
        public GetTemplateLayoutsResponse()
        {
        }
    }
}