
#nullable enable

namespace Presenton
{
    /// <summary>
    /// Presentation type<br/>
    /// Default Value: standard
    /// </summary>
    public enum ListChatConversationsApiV3ChatConversationsGetPresentationType
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
    public static class ListChatConversationsApiV3ChatConversationsGetPresentationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatConversationsApiV3ChatConversationsGetPresentationType value)
        {
            return value switch
            {
                ListChatConversationsApiV3ChatConversationsGetPresentationType.Smart => "smart",
                ListChatConversationsApiV3ChatConversationsGetPresentationType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatConversationsApiV3ChatConversationsGetPresentationType? ToEnum(string value)
        {
            return value switch
            {
                "smart" => ListChatConversationsApiV3ChatConversationsGetPresentationType.Smart,
                "standard" => ListChatConversationsApiV3ChatConversationsGetPresentationType.Standard,
                _ => null,
            };
        }
    }
}