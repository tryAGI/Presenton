
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePortalSessionApiV1BillingPortalSessionPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReturnUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePortalSessionApiV1BillingPortalSessionPost" /> class.
        /// </summary>
        /// <param name="returnUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreatePortalSessionApiV1BillingPortalSessionPost(
            string returnUrl)
        {
            this.ReturnUrl = returnUrl ?? throw new global::System.ArgumentNullException(nameof(returnUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePortalSessionApiV1BillingPortalSessionPost" /> class.
        /// </summary>
        public BodyCreatePortalSessionApiV1BillingPortalSessionPost()
        {
        }
    }
}