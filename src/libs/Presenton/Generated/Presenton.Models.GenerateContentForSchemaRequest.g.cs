
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateContentForSchemaRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.GenerateContentForSchemaRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.GenerateContentForSchemaRequestMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentForSchemaRequest" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateContentForSchemaRequest(
            global::Presenton.GenerateContentForSchemaRequestMode mode,
            object? schema)
        {
            this.Schema = schema;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentForSchemaRequest" /> class.
        /// </summary>
        public GenerateContentForSchemaRequest()
        {
        }
    }
}