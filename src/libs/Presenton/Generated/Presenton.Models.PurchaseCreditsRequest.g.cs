
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PurchaseCreditsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuccessUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CancelUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCreditsRequest" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="successUrl"></param>
        /// <param name="cancelUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PurchaseCreditsRequest(
            int amount,
            string successUrl,
            string cancelUrl)
        {
            this.Amount = amount;
            this.SuccessUrl = successUrl ?? throw new global::System.ArgumentNullException(nameof(successUrl));
            this.CancelUrl = cancelUrl ?? throw new global::System.ArgumentNullException(nameof(cancelUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCreditsRequest" /> class.
        /// </summary>
        public PurchaseCreditsRequest()
        {
        }
    }
}