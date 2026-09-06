
#nullable enable

namespace Presenton
{
    /// <summary>
    ///
    /// </summary>
    public enum EditSlideRequestExportAs
    {
        /// <summary>
        ///
        /// </summary>
        Pdf,
        /// <summary>
        ///
        /// </summary>
        Pptx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditSlideRequestExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditSlideRequestExportAs value)
        {
            return value switch
            {
                EditSlideRequestExportAs.Pdf => "pdf",
                EditSlideRequestExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditSlideRequestExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => EditSlideRequestExportAs.Pdf,
                "pptx" => EditSlideRequestExportAs.Pptx,
                _ => null,
            };
        }
    }
}