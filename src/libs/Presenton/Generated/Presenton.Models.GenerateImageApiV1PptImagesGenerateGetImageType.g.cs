
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: stock
    /// </summary>
    public enum GenerateImageApiV1PptImagesGenerateGetImageType
    {
        /// <summary>
        /// 
        /// </summary>
        AiGenerated,
        /// <summary>
        /// 
        /// </summary>
        Stock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImageApiV1PptImagesGenerateGetImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageApiV1PptImagesGenerateGetImageType value)
        {
            return value switch
            {
                GenerateImageApiV1PptImagesGenerateGetImageType.AiGenerated => "ai-generated",
                GenerateImageApiV1PptImagesGenerateGetImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageApiV1PptImagesGenerateGetImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => GenerateImageApiV1PptImagesGenerateGetImageType.AiGenerated,
                "stock" => GenerateImageApiV1PptImagesGenerateGetImageType.Stock,
                _ => null,
            };
        }
    }
}