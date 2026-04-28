
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseUserCreditsAddRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Enterprise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Default Value: Enterprise Credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseUserCreditsAddRequest" /> class.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="userId"></param>
        /// <param name="credits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="name">
        /// Default Value: Enterprise Credits
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseUserCreditsAddRequest(
            string enterprise,
            global::System.Guid userId,
            double credits,
            global::System.DateTime expiresAt,
            string? name,
            string? description)
        {
            this.Enterprise = enterprise ?? throw new global::System.ArgumentNullException(nameof(enterprise));
            this.UserId = userId;
            this.Credits = credits;
            this.ExpiresAt = expiresAt;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseUserCreditsAddRequest" /> class.
        /// </summary>
        public EnterpriseUserCreditsAddRequest()
        {
        }
    }
}