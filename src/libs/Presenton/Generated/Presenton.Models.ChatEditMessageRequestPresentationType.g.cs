
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: standard
    /// </summary>
    public enum ChatEditMessageRequestPresentationType
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
    public static class ChatEditMessageRequestPresentationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEditMessageRequestPresentationType value)
        {
            return value switch
            {
                ChatEditMessageRequestPresentationType.Smart => "smart",
                ChatEditMessageRequestPresentationType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEditMessageRequestPresentationType? ToEnum(string value)
        {
            return value switch
            {
                "smart" => ChatEditMessageRequestPresentationType.Smart,
                "standard" => ChatEditMessageRequestPresentationType.Standard,
                _ => null,
            };
        }
    }
}