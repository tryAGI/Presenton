
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveDesignReferenceData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Structure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide")]
        public int? Slide { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDesignReferenceData" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="structure"></param>
        /// <param name="slide"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveDesignReferenceData(
            string html,
            string structure,
            int? slide)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Structure = structure ?? throw new global::System.ArgumentNullException(nameof(structure));
            this.Slide = slide;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDesignReferenceData" /> class.
        /// </summary>
        public SaveDesignReferenceData()
        {
        }

    }
}