
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode
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
    public static class BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode value)
        {
            return value switch
            {
                BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode.Max => "max",
                BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode.Min => "min",
                BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode? ToEnum(string value)
        {
            return value switch
            {
                "max" => BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode.Max,
                "min" => BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode.Min,
                "normal" => BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode.Normal,
                _ => null,
            };
        }
    }
}