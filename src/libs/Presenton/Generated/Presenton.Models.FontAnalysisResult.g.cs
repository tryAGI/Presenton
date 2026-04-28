
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FontAnalysisResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internally_supported_fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> InternallySupportedFonts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_supported_fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NotSupportedFonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FontAnalysisResult" /> class.
        /// </summary>
        /// <param name="internallySupportedFonts"></param>
        /// <param name="notSupportedFonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FontAnalysisResult(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> internallySupportedFonts,
            global::System.Collections.Generic.IList<string> notSupportedFonts)
        {
            this.InternallySupportedFonts = internallySupportedFonts ?? throw new global::System.ArgumentNullException(nameof(internallySupportedFonts));
            this.NotSupportedFonts = notSupportedFonts ?? throw new global::System.ArgumentNullException(nameof(notSupportedFonts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FontAnalysisResult" /> class.
        /// </summary>
        public FontAnalysisResult()
        {
        }
    }
}