
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: standard
    /// </summary>
    public enum ChatMessageRequestPresentationType
    {
        /// <summary>
        /// 
        /// </summary>
        Smart,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRequestPresentationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRequestPresentationType value)
        {
            return value switch
            {
                ChatMessageRequestPresentationType.Smart => "smart",
                ChatMessageRequestPresentationType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRequestPresentationType? ToEnum(string value)
        {
            return value switch
            {
                "smart" => ChatMessageRequestPresentationType.Smart,
                "standard" => ChatMessageRequestPresentationType.Standard,
                _ => null,
            };
        }
    }
}