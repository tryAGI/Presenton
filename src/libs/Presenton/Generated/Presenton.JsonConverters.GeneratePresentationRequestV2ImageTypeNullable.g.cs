#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class GeneratePresentationRequestV2ImageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.GeneratePresentationRequestV2ImageType?>
    {
        /// <inheritdoc />
        public override global::Presenton.GeneratePresentationRequestV2ImageType? Read(
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
                        return global::Presenton.GeneratePresentationRequestV2ImageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.GeneratePresentationRequestV2ImageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.GeneratePresentationRequestV2ImageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.GeneratePresentationRequestV2ImageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.GeneratePresentationRequestV2ImageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
