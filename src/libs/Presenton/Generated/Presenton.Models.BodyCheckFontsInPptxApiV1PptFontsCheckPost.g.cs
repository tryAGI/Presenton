
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCheckFontsInPptxApiV1PptFontsCheckPost
    {
        /// <summary>
        /// PPTX file to analyze fonts from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] PptxFile { get; set; }

        /// <summary>
        /// PPTX file to analyze fonts from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PptxFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckFontsInPptxApiV1PptFontsCheckPost" /> class.
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to analyze fonts from
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCheckFontsInPptxApiV1PptFontsCheckPost(
            byte[] pptxFile,
            string pptxFilename)
        {
            this.PptxFile = pptxFile ?? throw new global::System.ArgumentNullException(nameof(pptxFile));
            this.PptxFilename = pptxFilename ?? throw new global::System.ArgumentNullException(nameof(pptxFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckFontsInPptxApiV1PptFontsCheckPost" /> class.
        /// </summary>
        public BodyCheckFontsInPptxApiV1PptFontsCheckPost()
        {
        }
    }
}