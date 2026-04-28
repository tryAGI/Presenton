
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Format to export the presentation as<br/>
    /// Default Value: pptx
    /// </summary>
    public enum BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs
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
    public static class BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs value)
        {
            return value switch
            {
                BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs.Pdf => "pdf",
                BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs.Png => "png",
                BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs.Pdf,
                "png" => BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs.Png,
                "pptx" => BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs.Pptx,
                _ => null,
            };
        }
    }
}