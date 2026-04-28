
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterprisePresentationsInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int V1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Api { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterprisePresentationsInfoResponse" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="v1"></param>
        /// <param name="api"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterprisePresentationsInfoResponse(
            int total,
            int v1,
            int api)
        {
            this.Total = total;
            this.V1 = v1;
            this.Api = api;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterprisePresentationsInfoResponse" /> class.
        /// </summary>
        public EnterprisePresentationsInfoResponse()
        {
        }
    }
}