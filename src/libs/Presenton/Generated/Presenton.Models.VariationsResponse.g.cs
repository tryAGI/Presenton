
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VariationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VariationsResponse" /> class.
        /// </summary>
        /// <param name="variations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VariationsResponse(
            global::System.Collections.Generic.IList<string> variations)
        {
            this.Variations = variations ?? throw new global::System.ArgumentNullException(nameof(variations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariationsResponse" /> class.
        /// </summary>
        public VariationsResponse()
        {
        }
    }
}