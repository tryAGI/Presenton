
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateHTMLPresentationResponseV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHTMLPresentationResponseV2" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateHTMLPresentationResponseV2(
            global::System.Guid presentationId,
            object fonts)
        {
            this.PresentationId = presentationId;
            this.Fonts = fonts ?? throw new global::System.ArgumentNullException(nameof(fonts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHTMLPresentationResponseV2" /> class.
        /// </summary>
        public GenerateHTMLPresentationResponseV2()
        {
        }
    }
}