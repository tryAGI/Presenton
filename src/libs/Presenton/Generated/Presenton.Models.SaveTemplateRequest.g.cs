
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveTemplateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_info_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TemplateInfoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData> Layouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateInfoId"></param>
        /// <param name="name"></param>
        /// <param name="layouts"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveTemplateRequest(
            global::System.Guid templateInfoId,
            string name,
            global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData> layouts,
            string? description)
        {
            this.TemplateInfoId = templateInfoId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTemplateRequest" /> class.
        /// </summary>
        public SaveTemplateRequest()
        {
        }
    }
}