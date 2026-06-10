
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Presentation type<br/>
    /// Default Value: standard
    /// </summary>
    public enum GetChatHistoryApiV3ChatHistoryGetPresentationType
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
    public static class GetChatHistoryApiV3ChatHistoryGetPresentationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatHistoryApiV3ChatHistoryGetPresentationType value)
        {
            return value switch
            {
                GetChatHistoryApiV3ChatHistoryGetPresentationType.Smart => "smart",
                GetChatHistoryApiV3ChatHistoryGetPresentationType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatHistoryApiV3ChatHistoryGetPresentationType? ToEnum(string value)
        {
            return value switch
            {
                "smart" => GetChatHistoryApiV3ChatHistoryGetPresentationType.Smart,
                "standard" => GetChatHistoryApiV3ChatHistoryGetPresentationType.Standard,
                _ => null,
            };
        }
    }
}