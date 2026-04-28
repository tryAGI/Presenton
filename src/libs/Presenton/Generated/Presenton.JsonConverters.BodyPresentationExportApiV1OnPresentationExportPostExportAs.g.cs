#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyPresentationExportApiV1OnPresentationExportPostExportAsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAs>
    {
        /// <inheritdoc />
        public override global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAs Read(
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
                        return global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAs);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAsExtensions.ToValueString(value));
        }
    }
}
