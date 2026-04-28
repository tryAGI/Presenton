
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Type of image to generate<br/>
    /// Default Value: stock
    /// </summary>
    public enum GeneratePresentationRequestV2ImageType
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
    public static class GeneratePresentationRequestV2ImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePresentationRequestV2ImageType value)
        {
            return value switch
            {
                GeneratePresentationRequestV2ImageType.AiGenerated => "ai-generated",
                GeneratePresentationRequestV2ImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePresentationRequestV2ImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => GeneratePresentationRequestV2ImageType.AiGenerated,
                "stock" => GeneratePresentationRequestV2ImageType.Stock,
                _ => null,
            };
        }
    }
}