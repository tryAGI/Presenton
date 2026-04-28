
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseCreditsInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRemaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseCreditsInfoResponse" /> class.
        /// </summary>
        /// <param name="totalAdded"></param>
        /// <param name="totalUsed"></param>
        /// <param name="totalRemaining"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseCreditsInfoResponse(
            double totalAdded,
            double totalUsed,
            double totalRemaining)
        {
            this.TotalAdded = totalAdded;
            this.TotalUsed = totalUsed;
            this.TotalRemaining = totalRemaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseCreditsInfoResponse" /> class.
        /// </summary>
        public EnterpriseCreditsInfoResponse()
        {
        }
    }
}