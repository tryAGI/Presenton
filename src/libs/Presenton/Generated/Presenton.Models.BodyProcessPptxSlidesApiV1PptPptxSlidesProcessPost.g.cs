
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost
    {
        /// <summary>
        /// PPTX file to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] PptxFile { get; set; }

        /// <summary>
        /// PPTX file to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PptxFilename { get; set; }

        /// <summary>
        /// Optional font files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        public global::System.Collections.Generic.IList<byte[]>? Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost" /> class.
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to process
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to process
        /// </param>
        /// <param name="fonts">
        /// Optional font files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost(
            byte[] pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fonts)
        {
            this.PptxFile = pptxFile ?? throw new global::System.ArgumentNullException(nameof(pptxFile));
            this.PptxFilename = pptxFilename ?? throw new global::System.ArgumentNullException(nameof(pptxFilename));
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost" /> class.
        /// </summary>
        public BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost()
        {
        }
    }
}