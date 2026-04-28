
#nullable enable

namespace Presenton
{
    /// <summary>
    /// The format to export the presentation as<br/>
    /// Default Value: pptx
    /// </summary>
    public enum CreatePresentationFromJsonRequestV3ExportAs
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
    public static class CreatePresentationFromJsonRequestV3ExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePresentationFromJsonRequestV3ExportAs value)
        {
            return value switch
            {
                CreatePresentationFromJsonRequestV3ExportAs.Pdf => "pdf",
                CreatePresentationFromJsonRequestV3ExportAs.Png => "png",
                CreatePresentationFromJsonRequestV3ExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePresentationFromJsonRequestV3ExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => CreatePresentationFromJsonRequestV3ExportAs.Pdf,
                "png" => CreatePresentationFromJsonRequestV3ExportAs.Png,
                "pptx" => CreatePresentationFromJsonRequestV3ExportAs.Pptx,
                _ => null,
            };
        }
    }
}