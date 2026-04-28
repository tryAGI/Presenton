#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreatePresentationFromJsonRequestV3ExportAsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.CreatePresentationFromJsonRequestV3ExportAs?>
    {
        /// <inheritdoc />
        public override global::Presenton.CreatePresentationFromJsonRequestV3ExportAs? Read(
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
                        return global::Presenton.CreatePresentationFromJsonRequestV3ExportAsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.CreatePresentationFromJsonRequestV3ExportAs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.CreatePresentationFromJsonRequestV3ExportAs?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.CreatePresentationFromJsonRequestV3ExportAs? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.CreatePresentationFromJsonRequestV3ExportAsExtensions.ToValueString(value.Value));
            }
        }
    }
}
