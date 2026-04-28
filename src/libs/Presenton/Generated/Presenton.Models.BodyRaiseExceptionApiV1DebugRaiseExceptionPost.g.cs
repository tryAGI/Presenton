
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRaiseExceptionApiV1DebugRaiseExceptionPost
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRaiseExceptionApiV1DebugRaiseExceptionPost" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="statusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyRaiseExceptionApiV1DebugRaiseExceptionPost(
            string token,
            int statusCode)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRaiseExceptionApiV1DebugRaiseExceptionPost" /> class.
        /// </summary>
        public BodyRaiseExceptionApiV1DebugRaiseExceptionPost()
        {
        }
    }
}