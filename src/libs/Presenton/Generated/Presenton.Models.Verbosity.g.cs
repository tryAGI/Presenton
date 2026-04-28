
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum Verbosity
    {
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        TextHeavy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Verbosity value)
        {
            return value switch
            {
                Verbosity.Concise => "concise",
                Verbosity.Standard => "standard",
                Verbosity.TextHeavy => "text-heavy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Verbosity? ToEnum(string value)
        {
            return value switch
            {
                "concise" => Verbosity.Concise,
                "standard" => Verbosity.Standard,
                "text-heavy" => Verbosity.TextHeavy,
                _ => null,
            };
        }
    }
}