
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum DownloadFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Appimage,
        /// <summary>
        /// 
        /// </summary>
        Deb,
        /// <summary>
        /// 
        /// </summary>
        Dmg,
        /// <summary>
        /// 
        /// </summary>
        Exe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DownloadFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DownloadFormat value)
        {
            return value switch
            {
                DownloadFormat.Appimage => "appimage",
                DownloadFormat.Deb => "deb",
                DownloadFormat.Dmg => "dmg",
                DownloadFormat.Exe => "exe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DownloadFormat? ToEnum(string value)
        {
            return value switch
            {
                "appimage" => DownloadFormat.Appimage,
                "deb" => DownloadFormat.Deb,
                "dmg" => DownloadFormat.Dmg,
                "exe" => DownloadFormat.Exe,
                _ => null,
            };
        }
    }
}