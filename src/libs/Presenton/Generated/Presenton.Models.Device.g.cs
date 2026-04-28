
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum Device
    {
        /// <summary>
        /// 
        /// </summary>
        Linux,
        /// <summary>
        /// 
        /// </summary>
        Macos,
        /// <summary>
        /// 
        /// </summary>
        Windows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Device value)
        {
            return value switch
            {
                Device.Linux => "linux",
                Device.Macos => "macos",
                Device.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Device? ToEnum(string value)
        {
            return value switch
            {
                "linux" => Device.Linux,
                "macos" => Device.Macos,
                "windows" => Device.Windows,
                _ => null,
            };
        }
    }
}