
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractDesignSystemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DesignSystem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDesignSystemResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="designSystem"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractDesignSystemResponse(
            bool success,
            object designSystem)
        {
            this.Success = success;
            this.DesignSystem = designSystem ?? throw new global::System.ArgumentNullException(nameof(designSystem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDesignSystemResponse" /> class.
        /// </summary>
        public ExtractDesignSystemResponse()
        {
        }
    }
}