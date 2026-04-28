
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveLayoutsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.LayoutData> Layouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveLayoutsRequest" /> class.
        /// </summary>
        /// <param name="layouts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveLayoutsRequest(
            global::System.Collections.Generic.IList<global::Presenton.LayoutData> layouts)
        {
            this.Layouts = layouts ?? throw new global::System.ArgumentNullException(nameof(layouts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveLayoutsRequest" /> class.
        /// </summary>
        public SaveLayoutsRequest()
        {
        }
    }
}