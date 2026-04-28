
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateContentForSchemaRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateContentForSchemaRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateContentForSchemaRequestMode value)
        {
            return value switch
            {
                GenerateContentForSchemaRequestMode.Max => "max",
                GenerateContentForSchemaRequestMode.Min => "min",
                GenerateContentForSchemaRequestMode.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateContentForSchemaRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "max" => GenerateContentForSchemaRequestMode.Max,
                "min" => GenerateContentForSchemaRequestMode.Min,
                "normal" => GenerateContentForSchemaRequestMode.Normal,
                _ => null,
            };
        }
    }
}