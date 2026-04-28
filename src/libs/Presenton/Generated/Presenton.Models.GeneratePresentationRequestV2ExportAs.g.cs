
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Export format<br/>
    /// Default Value: pptx
    /// </summary>
    public enum GeneratePresentationRequestV2ExportAs
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
    public static class GeneratePresentationRequestV2ExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePresentationRequestV2ExportAs value)
        {
            return value switch
            {
                GeneratePresentationRequestV2ExportAs.Pdf => "pdf",
                GeneratePresentationRequestV2ExportAs.Png => "png",
                GeneratePresentationRequestV2ExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePresentationRequestV2ExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => GeneratePresentationRequestV2ExportAs.Pdf,
                "png" => GeneratePresentationRequestV2ExportAs.Png,
                "pptx" => GeneratePresentationRequestV2ExportAs.Pptx,
                _ => null,
            };
        }
    }
}