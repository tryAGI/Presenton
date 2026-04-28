
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboarded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        public string? ProfilePicture { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="isActive"></param>
        /// <param name="isVerified"></param>
        /// <param name="isOnboarded"></param>
        /// <param name="name"></param>
        /// <param name="profilePicture"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserRead(
            global::System.Guid id,
            string email,
            bool isActive,
            bool isVerified,
            bool isOnboarded,
            string? name,
            string? profilePicture)
        {
            this.Id = id;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.IsActive = isActive;
            this.IsVerified = isVerified;
            this.IsOnboarded = isOnboarded;
            this.Name = name;
            this.ProfilePicture = profilePicture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRead" /> class.
        /// </summary>
        public UserRead()
        {
        }
    }
}