
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Subscription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_customer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripeCustomer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_subscription_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripeSubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled_at")]
        public global::System.DateTime? CanceledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at")]
        public global::System.DateTime? CancelAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at_period_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PriceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="stripeCustomer"></param>
        /// <param name="stripeSubscriptionId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="endingAt"></param>
        /// <param name="cancelAtPeriodEnd"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="priceId"></param>
        /// <param name="productId"></param>
        /// <param name="productName"></param>
        /// <param name="itemId"></param>
        /// <param name="id"></param>
        /// <param name="canceledAt"></param>
        /// <param name="cancelAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Subscription(
            global::System.DateTime updatedAt,
            string stripeCustomer,
            string stripeSubscriptionId,
            string status,
            global::System.DateTime createdAt,
            global::System.DateTime endingAt,
            bool cancelAtPeriodEnd,
            double amount,
            string currency,
            string priceId,
            string productId,
            string productName,
            string itemId,
            global::System.Guid? id,
            global::System.DateTime? canceledAt,
            global::System.DateTime? cancelAt)
        {
            this.Id = id;
            this.UpdatedAt = updatedAt;
            this.StripeCustomer = stripeCustomer ?? throw new global::System.ArgumentNullException(nameof(stripeCustomer));
            this.StripeSubscriptionId = stripeSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(stripeSubscriptionId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.EndingAt = endingAt;
            this.CanceledAt = canceledAt;
            this.CancelAt = cancelAt;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.Amount = amount;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.PriceId = priceId ?? throw new global::System.ArgumentNullException(nameof(priceId));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        public Subscription()
        {
        }
    }
}