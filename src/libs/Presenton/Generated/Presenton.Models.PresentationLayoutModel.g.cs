
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentationLayoutModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordered")]
        public bool? Ordered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SlideLayoutModel> Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationLayoutModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slides"></param>
        /// <param name="ordered">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentationLayoutModel(
            string name,
            global::System.Collections.Generic.IList<global::Presenton.SlideLayoutModel> slides,
            bool? ordered)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Ordered = ordered;
            this.Slides = slides ?? throw new global::System.ArgumentNullException(nameof(slides));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationLayoutModel" /> class.
        /// </summary>
        public PresentationLayoutModel()
        {
        }
    }
}