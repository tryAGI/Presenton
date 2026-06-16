
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] PptxFile { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost" /> class.
        /// </summary>
        /// <param name="pptxFile"></param>
        /// <param name="pptxFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost(
            byte[] pptxFile,
            string pptxFilename)
        {
            this.PptxFile = pptxFile ?? throw new global::System.ArgumentNullException(nameof(pptxFile));
            this.PptxFilename = pptxFilename ?? throw new global::System.ArgumentNullException(nameof(pptxFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost" /> class.
        /// </summary>
        public BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost()
        {
        }

    }
}