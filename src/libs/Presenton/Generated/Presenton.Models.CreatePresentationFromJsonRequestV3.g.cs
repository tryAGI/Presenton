
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePresentationFromJsonRequestV3
    {
        /// <summary>
        /// The language of the presentation<br/>
        /// Default Value: English
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The title of the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The template to use for the presentation. Available templates: neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift and your custom templates<br/>
        /// Default Value: general
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_template")]
        public string? StandardTemplate { get; set; }

        /// <summary>
        /// The theme to use for the presentation. Available themes: edge-yellow, light-rose, mint-blue, professional-blue, professional-dark and your custom themes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public string? Theme { get; set; }

        /// <summary>
        /// The slides to use for the presentation<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        public global::System.Collections.Generic.IList<global::Presenton.CreateSlideFromJsonRequestV1>? Slides { get; set; }

        /// <summary>
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.CreatePresentationFromJsonRequestV3ExportAsJsonConverter))]
        public global::Presenton.CreatePresentationFromJsonRequestV3ExportAs? ExportAs { get; set; }

        /// <summary>
        /// Whether to trigger subscribed webhooks<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_webhook")]
        public bool? TriggerWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePresentationFromJsonRequestV3" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the presentation<br/>
        /// Default Value: English
        /// </param>
        /// <param name="title">
        /// The title of the presentation
        /// </param>
        /// <param name="standardTemplate">
        /// The template to use for the presentation. Available templates: neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift and your custom templates<br/>
        /// Default Value: general
        /// </param>
        /// <param name="theme">
        /// The theme to use for the presentation. Available themes: edge-yellow, light-rose, mint-blue, professional-blue, professional-dark and your custom themes
        /// </param>
        /// <param name="slides">
        /// The slides to use for the presentation<br/>
        /// Default Value: []
        /// </param>
        /// <param name="exportAs">
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="triggerWebhook">
        /// Whether to trigger subscribed webhooks<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePresentationFromJsonRequestV3(
            string? language,
            string? title,
            string? standardTemplate,
            string? theme,
            global::System.Collections.Generic.IList<global::Presenton.CreateSlideFromJsonRequestV1>? slides,
            global::Presenton.CreatePresentationFromJsonRequestV3ExportAs? exportAs,
            bool? triggerWebhook)
        {
            this.Language = language;
            this.Title = title;
            this.StandardTemplate = standardTemplate;
            this.Theme = theme;
            this.Slides = slides;
            this.ExportAs = exportAs;
            this.TriggerWebhook = triggerWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePresentationFromJsonRequestV3" /> class.
        /// </summary>
        public CreatePresentationFromJsonRequestV3()
        {
        }
    }
}