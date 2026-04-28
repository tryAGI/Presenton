
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Guid? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_topup_amount")]
        public double? AutoTopupAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_topup_threshold")]
        public double? AutoTopupThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_topup_enabled")]
        public bool? AutoTopupEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("below_25_cost")]
        public double? Below25Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("below_50_cost")]
        public double? Below50Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("below_100_cost")]
        public double? Below100Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("above_100_cost")]
        public double? Above100Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditAccount" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="autoTopupAmount"></param>
        /// <param name="autoTopupThreshold"></param>
        /// <param name="autoTopupEnabled"></param>
        /// <param name="below25Cost"></param>
        /// <param name="below50Cost"></param>
        /// <param name="below100Cost"></param>
        /// <param name="above100Cost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditAccount(
            global::System.DateTime createdAt,
            string email,
            global::System.Guid? id,
            global::System.Guid? user,
            double? autoTopupAmount,
            double? autoTopupThreshold,
            bool? autoTopupEnabled,
            double? below25Cost,
            double? below50Cost,
            double? below100Cost,
            double? above100Cost)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.User = user;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.AutoTopupAmount = autoTopupAmount;
            this.AutoTopupThreshold = autoTopupThreshold;
            this.AutoTopupEnabled = autoTopupEnabled;
            this.Below25Cost = below25Cost;
            this.Below50Cost = below50Cost;
            this.Below100Cost = below100Cost;
            this.Above100Cost = above100Cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditAccount" /> class.
        /// </summary>
        public CreditAccount()
        {
        }
    }
}