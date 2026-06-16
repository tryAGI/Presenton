
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Default Value: standard
    /// </summary>
    public enum ChatHistoryResponsePresentationType
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
    public static class ChatHistoryResponsePresentationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatHistoryResponsePresentationType value)
        {
            return value switch
            {
                ChatHistoryResponsePresentationType.Smart => "smart",
                ChatHistoryResponsePresentationType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatHistoryResponsePresentationType? ToEnum(string value)
        {
            return value switch
            {
                "smart" => ChatHistoryResponsePresentationType.Smart,
                "standard" => ChatHistoryResponsePresentationType.Standard,
                _ => null,
            };
        }
    }
}