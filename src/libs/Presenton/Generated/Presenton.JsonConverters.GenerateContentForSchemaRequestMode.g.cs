#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateContentForSchemaRequestModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.GenerateContentForSchemaRequestMode>
    {
        /// <inheritdoc />
        public override global::Presenton.GenerateContentForSchemaRequestMode Read(
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
                        return global::Presenton.GenerateContentForSchemaRequestModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.GenerateContentForSchemaRequestMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.GenerateContentForSchemaRequestMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.GenerateContentForSchemaRequestMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Presenton.GenerateContentForSchemaRequestModeExtensions.ToValueString(value));
        }
    }
}
