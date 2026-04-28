
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditSlideLayoutResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("react_component")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactComponent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideLayoutResponse" /> class.
        /// </summary>
        /// <param name="reactComponent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditSlideLayoutResponse(
            string reactComponent)
        {
            this.ReactComponent = reactComponent ?? throw new global::System.ArgumentNullException(nameof(reactComponent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideLayoutResponse" /> class.
        /// </summary>
        public EditSlideLayoutResponse()
        {
        }
    }
}