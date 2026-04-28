
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditSlideRequestExportAs2
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
    public static class EditSlideRequestExportAs2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditSlideRequestExportAs2 value)
        {
            return value switch
            {
                EditSlideRequestExportAs2.Pdf => "pdf",
                EditSlideRequestExportAs2.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditSlideRequestExportAs2? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => EditSlideRequestExportAs2.Pdf,
                "pptx" => EditSlideRequestExportAs2.Pptx,
                _ => null,
            };
        }
    }
}