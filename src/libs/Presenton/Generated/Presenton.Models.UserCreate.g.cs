
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserCreate
    {
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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_superuser")]
        public bool? IsSuperuser { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public string? Enterprise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreate" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="isActive">
        /// Default Value: true
        /// </param>
        /// <param name="isSuperuser">
        /// Default Value: false
        /// </param>
        /// <param name="isVerified">
        /// Default Value: false
        /// </param>
        /// <param name="name"></param>
        /// <param name="enterprise"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserCreate(
            string email,
            string password,
            bool? isActive,
            bool? isSuperuser,
            bool? isVerified,
            string? name,
            string? enterprise)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.IsActive = isActive;
            this.IsSuperuser = isSuperuser;
            this.IsVerified = isVerified;
            this.Name = name;
            this.Enterprise = enterprise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreate" /> class.
        /// </summary>
        public UserCreate()
        {
        }
    }
}