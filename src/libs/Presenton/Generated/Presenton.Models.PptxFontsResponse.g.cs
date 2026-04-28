
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PptxFontsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.FontAnalysisResult Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PptxFontsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PptxFontsResponse(
            bool success,
            global::Presenton.FontAnalysisResult fonts)
        {
            this.Success = success;
            this.Fonts = fonts ?? throw new global::System.ArgumentNullException(nameof(fonts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PptxFontsResponse" /> class.
        /// </summary>
        public PptxFontsResponse()
        {
        }
    }
}