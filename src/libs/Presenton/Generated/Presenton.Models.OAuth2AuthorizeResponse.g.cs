
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuth2AuthorizeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorizationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AuthorizeResponse" /> class.
        /// </summary>
        /// <param name="authorizationUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2AuthorizeResponse(
            string authorizationUrl)
        {
            this.AuthorizationUrl = authorizationUrl ?? throw new global::System.ArgumentNullException(nameof(authorizationUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AuthorizeResponse" /> class.
        /// </summary>
        public OAuth2AuthorizeResponse()
        {
        }
    }
}