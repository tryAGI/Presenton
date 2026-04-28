
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseCreditsAddResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.UserRead User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditsAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_transaction_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreditTransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseCreditsAddResponse" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="creditsAdded"></param>
        /// <param name="balance"></param>
        /// <param name="creditTransactionId"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseCreditsAddResponse(
            global::Presenton.UserRead user,
            double creditsAdded,
            double balance,
            global::System.Guid creditTransactionId,
            global::System.DateTime expiresAt)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CreditsAdded = creditsAdded;
            this.Balance = balance;
            this.CreditTransactionId = creditTransactionId;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseCreditsAddResponse" /> class.
        /// </summary>
        public EnterpriseCreditsAddResponse()
        {
        }
    }
}