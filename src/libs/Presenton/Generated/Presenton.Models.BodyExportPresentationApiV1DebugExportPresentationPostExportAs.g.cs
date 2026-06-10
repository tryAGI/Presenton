
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyExportPresentationApiV1DebugExportPresentationPostExportAs
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
    public static class BodyExportPresentationApiV1DebugExportPresentationPostExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyExportPresentationApiV1DebugExportPresentationPostExportAs value)
        {
            return value switch
            {
                BodyExportPresentationApiV1DebugExportPresentationPostExportAs.Pdf => "pdf",
                BodyExportPresentationApiV1DebugExportPresentationPostExportAs.Png => "png",
                BodyExportPresentationApiV1DebugExportPresentationPostExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyExportPresentationApiV1DebugExportPresentationPostExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => BodyExportPresentationApiV1DebugExportPresentationPostExportAs.Pdf,
                "png" => BodyExportPresentationApiV1DebugExportPresentationPostExportAs.Png,
                "pptx" => BodyExportPresentationApiV1DebugExportPresentationPostExportAs.Pptx,
                _ => null,
            };
        }
    }
}