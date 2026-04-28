
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseUserAddRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseUserAddRequest" /> class.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseUserAddRequest(
            string enterprise,
            string email,
            string password,
            string? name)
        {
            this.Enterprise = enterprise ?? throw new global::System.ArgumentNullException(nameof(enterprise));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseUserAddRequest" /> class.
        /// </summary>
        public EnterpriseUserAddRequest()
        {
        }
    }
}