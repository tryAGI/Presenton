
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTemplateRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData> Layouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="layouts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTemplateRequest(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData> layouts)
        {
            this.Id = id;
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequest" /> class.
        /// </summary>
        public UpdateTemplateRequest()
        {
        }
    }
}