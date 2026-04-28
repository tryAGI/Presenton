#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs>
    {
        /// <inheritdoc />
        public override global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs Read(
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
                        return global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAsExtensions.ToValueString(value));
        }
    }
}
