
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost(
            object schema,
            global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode mode)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost" /> class.
        /// </summary>
        public BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost()
        {
        }

    }
}