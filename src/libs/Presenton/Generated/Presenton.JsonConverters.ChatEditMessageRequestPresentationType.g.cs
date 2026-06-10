#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatEditMessageRequestPresentationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.ChatEditMessageRequestPresentationType>
    {
        /// <inheritdoc />
        public override global::Presenton.ChatEditMessageRequestPresentationType Read(
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
                        return global::Presenton.ChatEditMessageRequestPresentationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.ChatEditMessageRequestPresentationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.ChatEditMessageRequestPresentationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.ChatEditMessageRequestPresentationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Presenton.ChatEditMessageRequestPresentationTypeExtensions.ToValueString(value));
        }
    }
}
