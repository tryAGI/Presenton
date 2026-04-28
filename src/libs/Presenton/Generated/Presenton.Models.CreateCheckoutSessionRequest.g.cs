
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCheckoutSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PriceId { get; set; }

        /// <summary>
        /// Default Value: subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionRequest" /> class.
        /// </summary>
        /// <param name="priceId"></param>
        /// <param name="successUrl"></param>
        /// <param name="cancelUrl"></param>
        /// <param name="mode">
        /// Default Value: subscription
        /// </param>
        /// <param name="quantity">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCheckoutSessionRequest(
            string priceId,
            string successUrl,
            string cancelUrl,
            string? mode,
            int? quantity)
        {
            this.PriceId = priceId ?? throw new global::System.ArgumentNullException(nameof(priceId));
            this.Mode = mode;
            this.Quantity = quantity;
            this.SuccessUrl = successUrl ?? throw new global::System.ArgumentNullException(nameof(successUrl));
            this.CancelUrl = cancelUrl ?? throw new global::System.ArgumentNullException(nameof(cancelUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionRequest" /> class.
        /// </summary>
        public CreateCheckoutSessionRequest()
        {
        }
    }
}