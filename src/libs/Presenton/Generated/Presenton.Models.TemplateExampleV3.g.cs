
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateExampleV3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StandardTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SlideExample> Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateExampleV3" /> class.
        /// </summary>
        /// <param name="standardTemplate"></param>
        /// <param name="slides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateExampleV3(
            string standardTemplate,
            global::System.Collections.Generic.IList<global::Presenton.SlideExample> slides)
        {
            this.StandardTemplate = standardTemplate ?? throw new global::System.ArgumentNullException(nameof(standardTemplate));
            this.Slides = slides ?? throw new global::System.ArgumentNullException(nameof(slides));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateExampleV3" /> class.
        /// </summary>
        public TemplateExampleV3()
        {
        }
    }
}