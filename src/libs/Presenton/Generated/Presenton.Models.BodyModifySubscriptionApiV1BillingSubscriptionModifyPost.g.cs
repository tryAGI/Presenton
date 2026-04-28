
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyModifySubscriptionApiV1BillingSubscriptionModifyPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PriceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyModifySubscriptionApiV1BillingSubscriptionModifyPost" /> class.
        /// </summary>
        /// <param name="priceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyModifySubscriptionApiV1BillingSubscriptionModifyPost(
            string priceId)
        {
            this.PriceId = priceId ?? throw new global::System.ArgumentNullException(nameof(priceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyModifySubscriptionApiV1BillingSubscriptionModifyPost" /> class.
        /// </summary>
        public BodyModifySubscriptionApiV1BillingSubscriptionModifyPost()
        {
        }
    }
}