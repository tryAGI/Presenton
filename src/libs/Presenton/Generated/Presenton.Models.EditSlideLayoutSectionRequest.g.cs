
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditSlideLayoutSectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("react_component")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactComponent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Section { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideLayoutSectionRequest" /> class.
        /// </summary>
        /// <param name="reactComponent"></param>
        /// <param name="section"></param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditSlideLayoutSectionRequest(
            string reactComponent,
            string section,
            string prompt)
        {
            this.ReactComponent = reactComponent ?? throw new global::System.ArgumentNullException(nameof(reactComponent));
            this.Section = section ?? throw new global::System.ArgumentNullException(nameof(section));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSlideLayoutSectionRequest" /> class.
        /// </summary>
        public EditSlideLayoutSectionRequest()
        {
        }
    }
}