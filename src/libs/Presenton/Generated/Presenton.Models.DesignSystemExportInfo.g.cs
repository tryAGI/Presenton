
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DesignSystemExportInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedded_eot_fonts")]
        public global::System.Collections.Generic.IList<string>? EmbeddedEotFonts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedded_fonts_info")]
        public global::System.Collections.Generic.IList<object>? EmbeddedFontsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme_archive_url")]
        public string? ThemeArchiveUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignSystemExportInfo" /> class.
        /// </summary>
        /// <param name="embeddedEotFonts"></param>
        /// <param name="embeddedFontsInfo"></param>
        /// <param name="themeArchiveUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesignSystemExportInfo(
            global::System.Collections.Generic.IList<string>? embeddedEotFonts,
            global::System.Collections.Generic.IList<object>? embeddedFontsInfo,
            string? themeArchiveUrl)
        {
            this.EmbeddedEotFonts = embeddedEotFonts;
            this.EmbeddedFontsInfo = embeddedFontsInfo;
            this.ThemeArchiveUrl = themeArchiveUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignSystemExportInfo" /> class.
        /// </summary>
        public DesignSystemExportInfo()
        {
        }
    }
}