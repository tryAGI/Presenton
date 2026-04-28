#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreatePresentationFromJsonRequestV1ExportAsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.CreatePresentationFromJsonRequestV1ExportAs>
    {
        /// <inheritdoc />
        public override global::Presenton.CreatePresentationFromJsonRequestV1ExportAs Read(
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
                        return global::Presenton.CreatePresentationFromJsonRequestV1ExportAsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.CreatePresentationFromJsonRequestV1ExportAs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.CreatePresentationFromJsonRequestV1ExportAs);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.CreatePresentationFromJsonRequestV1ExportAs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Presenton.CreatePresentationFromJsonRequestV1ExportAsExtensions.ToValueString(value));
        }
    }
}
