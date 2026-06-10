
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentionThemeFonts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textFont")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.PresentionThemeTextFont TextFont { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentionThemeFonts" /> class.
        /// </summary>
        /// <param name="textFont"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentionThemeFonts(
            global::Presenton.PresentionThemeTextFont textFont)
        {
            this.TextFont = textFont ?? throw new global::System.ArgumentNullException(nameof(textFont));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentionThemeFonts" /> class.
        /// </summary>
        public PresentionThemeFonts()
        {
        }

    }
}