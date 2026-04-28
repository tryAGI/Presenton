
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyPresentationExportApiV2OnPresentationExportPostExportAs
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
    public static class BodyPresentationExportApiV2OnPresentationExportPostExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyPresentationExportApiV2OnPresentationExportPostExportAs value)
        {
            return value switch
            {
                BodyPresentationExportApiV2OnPresentationExportPostExportAs.Pdf => "pdf",
                BodyPresentationExportApiV2OnPresentationExportPostExportAs.Png => "png",
                BodyPresentationExportApiV2OnPresentationExportPostExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyPresentationExportApiV2OnPresentationExportPostExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => BodyPresentationExportApiV2OnPresentationExportPostExportAs.Pdf,
                "png" => BodyPresentationExportApiV2OnPresentationExportPostExportAs.Png,
                "pptx" => BodyPresentationExportApiV2OnPresentationExportPostExportAs.Pptx,
                _ => null,
            };
        }
    }
}