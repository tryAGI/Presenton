
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Format to export the presentation as
    /// </summary>
    public enum BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs
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
    public static class BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs value)
        {
            return value switch
            {
                BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs.Pdf => "pdf",
                BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs.Png => "png",
                BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs.Pdf,
                "png" => BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs.Png,
                "pptx" => BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs.Pptx,
                _ => null,
            };
        }
    }
}