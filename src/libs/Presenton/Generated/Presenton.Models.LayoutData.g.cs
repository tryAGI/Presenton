
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Presentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayoutCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>))]
        public global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>? Fonts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutData" /> class.
        /// </summary>
        /// <param name="presentation"></param>
        /// <param name="layoutId"></param>
        /// <param name="layoutName"></param>
        /// <param name="layoutCode"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutData(
            global::System.Guid presentation,
            string layoutId,
            string layoutName,
            string layoutCode,
            global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>? fonts)
        {
            this.Presentation = presentation;
            this.LayoutId = layoutId ?? throw new global::System.ArgumentNullException(nameof(layoutId));
            this.LayoutName = layoutName ?? throw new global::System.ArgumentNullException(nameof(layoutName));
            this.LayoutCode = layoutCode ?? throw new global::System.ArgumentNullException(nameof(layoutCode));
            this.Fonts = fonts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutData" /> class.
        /// </summary>
        public LayoutData()
        {
        }
    }
}