
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Type of image to generate<br/>
    /// Default Value: stock
    /// </summary>
    public enum GeneratePresentationRequestV1ImageType
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
    public static class GeneratePresentationRequestV1ImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePresentationRequestV1ImageType value)
        {
            return value switch
            {
                GeneratePresentationRequestV1ImageType.AiGenerated => "ai-generated",
                GeneratePresentationRequestV1ImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePresentationRequestV1ImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => GeneratePresentationRequestV1ImageType.AiGenerated,
                "stock" => GeneratePresentationRequestV1ImageType.Stock,
                _ => null,
            };
        }
    }
}