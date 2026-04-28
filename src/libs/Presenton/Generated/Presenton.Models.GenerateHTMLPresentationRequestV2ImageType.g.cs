
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: ai-generated
    /// </summary>
    public enum GenerateHTMLPresentationRequestV2ImageType
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
    public static class GenerateHTMLPresentationRequestV2ImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateHTMLPresentationRequestV2ImageType value)
        {
            return value switch
            {
                GenerateHTMLPresentationRequestV2ImageType.AiGenerated => "ai-generated",
                GenerateHTMLPresentationRequestV2ImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateHTMLPresentationRequestV2ImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => GenerateHTMLPresentationRequestV2ImageType.AiGenerated,
                "stock" => GenerateHTMLPresentationRequestV2ImageType.Stock,
                _ => null,
            };
        }
    }
}