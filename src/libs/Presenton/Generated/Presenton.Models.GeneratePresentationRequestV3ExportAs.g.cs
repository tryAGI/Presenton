
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Export format<br/>
    /// Default Value: pptx
    /// </summary>
    public enum GeneratePresentationRequestV3ExportAs
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
    public static class GeneratePresentationRequestV3ExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePresentationRequestV3ExportAs value)
        {
            return value switch
            {
                GeneratePresentationRequestV3ExportAs.Pdf => "pdf",
                GeneratePresentationRequestV3ExportAs.Png => "png",
                GeneratePresentationRequestV3ExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePresentationRequestV3ExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => GeneratePresentationRequestV3ExportAs.Pdf,
                "png" => GeneratePresentationRequestV3ExportAs.Png,
                "pptx" => GeneratePresentationRequestV3ExportAs.Pptx,
                _ => null,
            };
        }
    }
}