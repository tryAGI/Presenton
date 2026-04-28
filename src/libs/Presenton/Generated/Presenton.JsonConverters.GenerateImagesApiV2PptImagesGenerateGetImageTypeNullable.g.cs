#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateImagesApiV2PptImagesGenerateGetImageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType?>
    {
        /// <inheritdoc />
        public override global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType? Read(
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
                        return global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
