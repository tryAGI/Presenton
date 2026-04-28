
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentGenerationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Condense,
        /// <summary>
        /// 
        /// </summary>
        Enhance,
        /// <summary>
        /// 
        /// </summary>
        Preserve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentGenerationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentGenerationMode value)
        {
            return value switch
            {
                ContentGenerationMode.Condense => "condense",
                ContentGenerationMode.Enhance => "enhance",
                ContentGenerationMode.Preserve => "preserve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentGenerationMode? ToEnum(string value)
        {
            return value switch
            {
                "condense" => ContentGenerationMode.Condense,
                "enhance" => ContentGenerationMode.Enhance,
                "preserve" => ContentGenerationMode.Preserve,
                _ => null,
            };
        }
    }
}