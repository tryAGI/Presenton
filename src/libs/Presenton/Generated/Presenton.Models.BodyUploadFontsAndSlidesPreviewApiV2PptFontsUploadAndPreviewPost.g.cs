
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost
    {
        /// <summary>
        /// PPTX file to modify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] PptxFile { get; set; }

        /// <summary>
        /// PPTX file to modify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pptx_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PptxFilename { get; set; }

        /// <summary>
        /// Font files to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_files")]
        public global::System.Collections.Generic.IList<byte[]>? FontFiles { get; set; }

        /// <summary>
        /// Original font names to replace (same order as font_files)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_font_names")]
        public global::System.Collections.Generic.IList<string>? OriginalFontNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost" /> class.
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to modify
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to modify
        /// </param>
        /// <param name="fontFiles">
        /// Font files to upload
        /// </param>
        /// <param name="originalFontNames">
        /// Original font names to replace (same order as font_files)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost(
            byte[] pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fontFiles,
            global::System.Collections.Generic.IList<string>? originalFontNames)
        {
            this.PptxFile = pptxFile ?? throw new global::System.ArgumentNullException(nameof(pptxFile));
            this.PptxFilename = pptxFilename ?? throw new global::System.ArgumentNullException(nameof(pptxFilename));
            this.FontFiles = fontFiles;
            this.OriginalFontNames = originalFontNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost" /> class.
        /// </summary>
        public BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost()
        {
        }
    }
}