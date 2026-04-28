
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FontCheckResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.FontInfo> AvailableFonts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailable_fonts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.FontInfo> UnavailableFonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FontCheckResponse" /> class.
        /// </summary>
        /// <param name="availableFonts"></param>
        /// <param name="unavailableFonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FontCheckResponse(
            global::System.Collections.Generic.IList<global::Presenton.FontInfo> availableFonts,
            global::System.Collections.Generic.IList<global::Presenton.FontInfo> unavailableFonts)
        {
            this.AvailableFonts = availableFonts ?? throw new global::System.ArgumentNullException(nameof(availableFonts));
            this.UnavailableFonts = unavailableFonts ?? throw new global::System.ArgumentNullException(nameof(unavailableFonts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FontCheckResponse" /> class.
        /// </summary>
        public FontCheckResponse()
        {
        }
    }
}