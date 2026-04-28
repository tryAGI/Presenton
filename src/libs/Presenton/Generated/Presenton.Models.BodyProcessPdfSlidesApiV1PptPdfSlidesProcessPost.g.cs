
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost
    {
        /// <summary>
        /// PDF file to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] PdfFile { get; set; }

        /// <summary>
        /// PDF file to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PdfFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost" /> class.
        /// </summary>
        /// <param name="pdfFile">
        /// PDF file to process
        /// </param>
        /// <param name="pdfFilename">
        /// PDF file to process
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost(
            byte[] pdfFile,
            string pdfFilename)
        {
            this.PdfFile = pdfFile ?? throw new global::System.ArgumentNullException(nameof(pdfFile));
            this.PdfFilename = pdfFilename ?? throw new global::System.ArgumentNullException(nameof(pdfFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost" /> class.
        /// </summary>
        public BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost()
        {
        }
    }
}