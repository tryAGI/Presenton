
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySendWelcomeEmailApiV1DebugSendWelcomeEmailPost
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
        /// Default Value: welcome
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendWelcomeEmailApiV1DebugSendWelcomeEmailPost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="email"></param>
        /// <param name="template">
        /// Default Value: welcome
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySendWelcomeEmailApiV1DebugSendWelcomeEmailPost(
            string token,
            string email,
            string? template)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendWelcomeEmailApiV1DebugSendWelcomeEmailPost" /> class.
        /// </summary>
        public BodySendWelcomeEmailApiV1DebugSendWelcomeEmailPost()
        {
        }
    }
}