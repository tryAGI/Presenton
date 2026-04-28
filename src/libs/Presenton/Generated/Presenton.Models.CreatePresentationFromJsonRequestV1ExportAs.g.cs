
#nullable enable

namespace Presenton
{
    /// <summary>
    /// The format to export the presentation as<br/>
    /// Default Value: pptx
    /// </summary>
    public enum CreatePresentationFromJsonRequestV1ExportAs
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
    public static class CreatePresentationFromJsonRequestV1ExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePresentationFromJsonRequestV1ExportAs value)
        {
            return value switch
            {
                CreatePresentationFromJsonRequestV1ExportAs.Pdf => "pdf",
                CreatePresentationFromJsonRequestV1ExportAs.Png => "png",
                CreatePresentationFromJsonRequestV1ExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePresentationFromJsonRequestV1ExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => CreatePresentationFromJsonRequestV1ExportAs.Pdf,
                "png" => CreatePresentationFromJsonRequestV1ExportAs.Png,
                "pptx" => CreatePresentationFromJsonRequestV1ExportAs.Pptx,
                _ => null,
            };
        }
    }
}