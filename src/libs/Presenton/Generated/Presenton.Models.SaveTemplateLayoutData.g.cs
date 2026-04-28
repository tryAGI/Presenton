
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveTemplateLayoutData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTemplateLayoutData" /> class.
        /// </summary>
        /// <param name="layoutId"></param>
        /// <param name="layoutName"></param>
        /// <param name="layoutCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveTemplateLayoutData(
            string layoutId,
            string layoutName,
            string layoutCode)
        {
            this.LayoutId = layoutId ?? throw new global::System.ArgumentNullException(nameof(layoutId));
            this.LayoutName = layoutName ?? throw new global::System.ArgumentNullException(nameof(layoutName));
            this.LayoutCode = layoutCode ?? throw new global::System.ArgumentNullException(nameof(layoutCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTemplateLayoutData" /> class.
        /// </summary>
        public SaveTemplateLayoutData()
        {
        }
    }
}