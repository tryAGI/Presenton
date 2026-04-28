
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddCreditsApiV1DebugAddCreditsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_name")]
        public string? TransactionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_description")]
        public string? TransactionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddCreditsApiV1DebugAddCreditsPost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="credits"></param>
        /// <param name="user"></param>
        /// <param name="expiresAt"></param>
        /// <param name="transactionName"></param>
        /// <param name="transactionDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddCreditsApiV1DebugAddCreditsPost(
            string token,
            int credits,
            global::System.Guid user,
            global::System.DateTime expiresAt,
            string? transactionName,
            string? transactionDescription)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Credits = credits;
            this.User = user;
            this.ExpiresAt = expiresAt;
            this.TransactionName = transactionName;
            this.TransactionDescription = transactionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddCreditsApiV1DebugAddCreditsPost" /> class.
        /// </summary>
        public BodyAddCreditsApiV1DebugAddCreditsPost()
        {
        }
    }
}