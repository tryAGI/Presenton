
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlideOutlineModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        public string? Layout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideOutlineModel" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="layout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlideOutlineModel(
            string content,
            string? layout)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Layout = layout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlideOutlineModel" /> class.
        /// </summary>
        public SlideOutlineModel()
        {
        }

    }
}