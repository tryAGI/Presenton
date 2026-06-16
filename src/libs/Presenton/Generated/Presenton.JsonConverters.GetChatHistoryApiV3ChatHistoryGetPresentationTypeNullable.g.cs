#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetChatHistoryApiV3ChatHistoryGetPresentationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType?>
    {
        /// <inheritdoc />
        public override global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType? Read(
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
                        return global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
