
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySendPaymentFailedEmailApiV1DebugSendPaymentFailedEmailPost
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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendPaymentFailedEmailApiV1DebugSendPaymentFailedEmailPost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySendPaymentFailedEmailApiV1DebugSendPaymentFailedEmailPost(
            string token,
            string email)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendPaymentFailedEmailApiV1DebugSendPaymentFailedEmailPost" /> class.
        /// </summary>
        public BodySendPaymentFailedEmailApiV1DebugSendPaymentFailedEmailPost()
        {
        }
    }
}