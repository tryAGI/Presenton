
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Type of image to generate<br/>
    /// Default Value: stock
    /// </summary>
    public enum GeneratePresentationRequestV3ImageType
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
    public static class GeneratePresentationRequestV3ImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratePresentationRequestV3ImageType value)
        {
            return value switch
            {
                GeneratePresentationRequestV3ImageType.AiGenerated => "ai-generated",
                GeneratePresentationRequestV3ImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratePresentationRequestV3ImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => GeneratePresentationRequestV3ImageType.AiGenerated,
                "stock" => GeneratePresentationRequestV3ImageType.Stock,
                _ => null,
            };
        }
    }
}