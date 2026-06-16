#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListChatConversationsApiV3ChatConversationsGetPresentationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType?>
    {
        /// <inheritdoc />
        public override global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
