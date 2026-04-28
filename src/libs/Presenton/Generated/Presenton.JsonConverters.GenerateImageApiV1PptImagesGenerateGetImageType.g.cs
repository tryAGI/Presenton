#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateImageApiV1PptImagesGenerateGetImageTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType>
    {
        /// <inheritdoc />
        public override global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType Read(
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
                        return global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageTypeExtensions.ToValueString(value));
        }
    }
}
