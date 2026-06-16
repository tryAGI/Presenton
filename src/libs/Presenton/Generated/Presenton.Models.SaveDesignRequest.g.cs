
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveDesignRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_id")]
        public global::System.Guid? DesignId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_info_id")]
        public global::System.Guid? DesignInfoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SaveDesignReferenceData> References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDesignRequest" /> class.
        /// </summary>
        /// <param name="references"></param>
        /// <param name="designId"></param>
        /// <param name="designInfoId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveDesignRequest(
            global::System.Collections.Generic.IList<global::Presenton.SaveDesignReferenceData> references,
            global::System.Guid? designId,
            global::System.Guid? designInfoId,
            string? name)
        {
            this.DesignId = designId;
            this.DesignInfoId = designInfoId;
            this.Name = name;
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDesignRequest" /> class.
        /// </summary>
        public SaveDesignRequest()
        {
        }

    }
}