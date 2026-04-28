
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Format to export the presentation as<br/>
    /// Default Value: pptx
    /// </summary>
    public enum BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs
    {
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Pptx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs value)
        {
            return value switch
            {
                BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs.Pdf => "pdf",
                BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs.Png => "png",
                BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs.Pdf,
                "png" => BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs.Png,
                "pptx" => BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs.Pptx,
                _ => null,
            };
        }
    }
}