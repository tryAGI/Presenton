
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FontListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.FontDetail> Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FontListResponse" /> class.
        /// </summary>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FontListResponse(
            global::System.Collections.Generic.IList<global::Presenton.FontDetail> fonts)
        {
            this.Fonts = fonts ?? throw new global::System.ArgumentNullException(nameof(fonts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FontListResponse" /> class.
        /// </summary>
        public FontListResponse()
        {
        }
    }
}