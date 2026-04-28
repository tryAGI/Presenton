
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractDesignSystemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.DesignSystemSlideInput> Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDesignSystemRequest" /> class.
        /// </summary>
        /// <param name="slides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractDesignSystemRequest(
            global::System.Collections.Generic.IList<global::Presenton.DesignSystemSlideInput> slides)
        {
            this.Slides = slides ?? throw new global::System.ArgumentNullException(nameof(slides));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDesignSystemRequest" /> class.
        /// </summary>
        public ExtractDesignSystemRequest()
        {
        }
    }
}