
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: stock
    /// </summary>
    public enum BodyCreatePresentationApiV1PptPresentationCreatePostImageType
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
    public static class BodyCreatePresentationApiV1PptPresentationCreatePostImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePresentationApiV1PptPresentationCreatePostImageType value)
        {
            return value switch
            {
                BodyCreatePresentationApiV1PptPresentationCreatePostImageType.AiGenerated => "ai-generated",
                BodyCreatePresentationApiV1PptPresentationCreatePostImageType.Stock => "stock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePresentationApiV1PptPresentationCreatePostImageType? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => BodyCreatePresentationApiV1PptPresentationCreatePostImageType.AiGenerated,
                "stock" => BodyCreatePresentationApiV1PptPresentationCreatePostImageType.Stock,
                _ => null,
            };
        }
    }
}