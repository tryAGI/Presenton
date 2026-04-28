
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum Tone
    {
        /// <summary>
        /// 
        /// </summary>
        Casual,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Educational,
        /// <summary>
        /// 
        /// </summary>
        Funny,
        /// <summary>
        /// 
        /// </summary>
        Professional,
        /// <summary>
        /// 
        /// </summary>
        SalesPitch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Tone value)
        {
            return value switch
            {
                Tone.Casual => "casual",
                Tone.Default => "default",
                Tone.Educational => "educational",
                Tone.Funny => "funny",
                Tone.Professional => "professional",
                Tone.SalesPitch => "sales_pitch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Tone? ToEnum(string value)
        {
            return value switch
            {
                "casual" => Tone.Casual,
                "default" => Tone.Default,
                "educational" => Tone.Educational,
                "funny" => Tone.Funny,
                "professional" => Tone.Professional,
                "sales_pitch" => Tone.SalesPitch,
                _ => null,
            };
        }
    }
}