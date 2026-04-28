
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSlideRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qualitativechart")]
        public global::Presenton.QualitativeChart? Qualitativechart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSlideRequest" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="prompt"></param>
        /// <param name="qualitativechart"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSlideRequest(
            global::System.Guid presentationId,
            string prompt,
            global::Presenton.QualitativeChart? qualitativechart)
        {
            this.PresentationId = presentationId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Qualitativechart = qualitativechart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSlideRequest" /> class.
        /// </summary>
        public GenerateSlideRequest()
        {
        }
    }
}