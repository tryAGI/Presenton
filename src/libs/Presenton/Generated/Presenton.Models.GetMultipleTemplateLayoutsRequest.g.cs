
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMultipleTemplateLayoutsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TemplateIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleTemplateLayoutsRequest" /> class.
        /// </summary>
        /// <param name="templateIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMultipleTemplateLayoutsRequest(
            global::System.Collections.Generic.IList<string> templateIds)
        {
            this.TemplateIds = templateIds ?? throw new global::System.ArgumentNullException(nameof(templateIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultipleTemplateLayoutsRequest" /> class.
        /// </summary>
        public GetMultipleTemplateLayoutsRequest()
        {
        }

    }
}