
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddSubscriptionApiV1DebugAddSubscriptionPost
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSubscriptionApiV1DebugAddSubscriptionPost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="user"></param>
        /// <param name="productName"></param>
        /// <param name="endingAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddSubscriptionApiV1DebugAddSubscriptionPost(
            string token,
            global::System.Guid user,
            string productName,
            global::System.DateTime endingAt)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.User = user;
            this.ProductName = productName ?? throw new global::System.ArgumentNullException(nameof(productName));
            this.EndingAt = endingAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSubscriptionApiV1DebugAddSubscriptionPost" /> class.
        /// </summary>
        public BodyAddSubscriptionApiV1DebugAddSubscriptionPost()
        {
        }
    }
}