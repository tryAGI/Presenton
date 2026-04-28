
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteUserApiV1DebugDeleteUserDelete
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
        /// Initializes a new instance of the <see cref="BodyDeleteUserApiV1DebugDeleteUserDelete" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDeleteUserApiV1DebugDeleteUserDelete(
            string token,
            global::System.Guid user)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteUserApiV1DebugDeleteUserDelete" /> class.
        /// </summary>
        public BodyDeleteUserApiV1DebugDeleteUserDelete()
        {
        }
    }
}