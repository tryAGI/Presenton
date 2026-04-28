
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Export format<br/>
    /// Default Value: pptx
    /// </summary>
    public enum GeneratePresentationRequestV1ExportAs
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
    public static class GeneratePresentationRequestV1ExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePresentationRequestV1ExportAs value)
        {
            return value switch
            {
                GeneratePresentationRequestV1ExportAs.Pdf => "pdf",
                GeneratePresentationRequestV1ExportAs.Png => "png",
                GeneratePresentationRequestV1ExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePresentationRequestV1ExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => GeneratePresentationRequestV1ExportAs.Pdf,
                "png" => GeneratePresentationRequestV1ExportAs.Png,
                "pptx" => GeneratePresentationRequestV1ExportAs.Pptx,
                _ => null,
            };
        }
    }
}