
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCheckCreditBalanceApiV1DebugCheckCreditBalancePost
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
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckCreditBalanceApiV1DebugCheckCreditBalancePost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCheckCreditBalanceApiV1DebugCheckCreditBalancePost(
            string token,
            global::System.Guid user)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckCreditBalanceApiV1DebugCheckCreditBalancePost" /> class.
        /// </summary>
        public BodyCheckCreditBalanceApiV1DebugCheckCreditBalancePost()
        {
        }
    }
}