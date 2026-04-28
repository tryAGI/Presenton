
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateThemeRequestV3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public string? Primary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public string? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_1")]
        public string? Accent1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_2")]
        public string? Accent2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_1")]
        public string? Text1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_2")]
        public string? Text2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateThemeRequestV3" /> class.
        /// </summary>
        /// <param name="primary"></param>
        /// <param name="background"></param>
        /// <param name="accent1"></param>
        /// <param name="accent2"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateThemeRequestV3(
            string? primary,
            string? background,
            string? accent1,
            string? accent2,
            string? text1,
            string? text2)
        {
            this.Primary = primary;
            this.Background = background;
            this.Accent1 = accent1;
            this.Accent2 = accent2;
            this.Text1 = text1;
            this.Text2 = text2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateThemeRequestV3" /> class.
        /// </summary>
        public GenerateThemeRequestV3()
        {
        }
    }
}