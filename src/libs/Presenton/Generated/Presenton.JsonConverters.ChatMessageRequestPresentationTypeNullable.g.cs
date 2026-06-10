#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatMessageRequestPresentationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.ChatMessageRequestPresentationType?>
    {
        /// <inheritdoc />
        public override global::Presenton.ChatMessageRequestPresentationType? Read(
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
                        return global::Presenton.ChatMessageRequestPresentationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.ChatMessageRequestPresentationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.ChatMessageRequestPresentationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.ChatMessageRequestPresentationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.ChatMessageRequestPresentationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
