#nullable enable

namespace Presenton.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode?>
    {
        /// <inheritdoc />
        public override global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode? Read(
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
                        return global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
