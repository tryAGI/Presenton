
#nullable enable

namespace Presenton
{
    /// <summary>
    /// The format to export the presentation as<br/>
    /// Default Value: pptx
    /// </summary>
    public enum EditPresentationRequestExportAs
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
    public static class EditPresentationRequestExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditPresentationRequestExportAs value)
        {
            return value switch
            {
                EditPresentationRequestExportAs.Pdf => "pdf",
                EditPresentationRequestExportAs.Png => "png",
                EditPresentationRequestExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditPresentationRequestExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => EditPresentationRequestExportAs.Pdf,
                "png" => EditPresentationRequestExportAs.Png,
                "pptx" => EditPresentationRequestExportAs.Pptx,
                _ => null,
            };
        }
    }
}