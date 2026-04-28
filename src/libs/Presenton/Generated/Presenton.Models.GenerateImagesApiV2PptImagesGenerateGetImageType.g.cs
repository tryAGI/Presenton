
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: stock
    /// </summary>
    public enum GenerateImagesApiV2PptImagesGenerateGetImageType
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
    public static class GenerateImagesApiV2PptImagesGenerateGetImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImagesApiV2PptImagesGenerateGetImageType value)
        {
            return value switch
            {
                GenerateImagesApiV2PptImagesGenerateGetImageType.AiGenerated => "ai-generated",
                GenerateImagesApiV2PptImagesGenerateGetImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImagesApiV2PptImagesGenerateGetImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => GenerateImagesApiV2PptImagesGenerateGetImageType.AiGenerated,
                "stock" => GenerateImagesApiV2PptImagesGenerateGetImageType.Stock,
                _ => null,
            };
        }
    }
}