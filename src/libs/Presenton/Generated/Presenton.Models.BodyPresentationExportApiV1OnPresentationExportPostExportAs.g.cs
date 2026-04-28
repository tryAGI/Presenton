
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyPresentationExportApiV1OnPresentationExportPostExportAs
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
    public static class BodyPresentationExportApiV1OnPresentationExportPostExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyPresentationExportApiV1OnPresentationExportPostExportAs value)
        {
            return value switch
            {
                BodyPresentationExportApiV1OnPresentationExportPostExportAs.Pdf => "pdf",
                BodyPresentationExportApiV1OnPresentationExportPostExportAs.Png => "png",
                BodyPresentationExportApiV1OnPresentationExportPostExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyPresentationExportApiV1OnPresentationExportPostExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => BodyPresentationExportApiV1OnPresentationExportPostExportAs.Pdf,
                "png" => BodyPresentationExportApiV1OnPresentationExportPostExportAs.Png,
                "pptx" => BodyPresentationExportApiV1OnPresentationExportPostExportAs.Pptx,
                _ => null,
            };
        }
    }
}