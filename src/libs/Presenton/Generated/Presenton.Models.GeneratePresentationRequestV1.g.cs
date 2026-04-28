
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePresentationRequestV1
    {
        /// <summary>
        /// The content for generating the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The markdown for the slides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides_markdown")]
        public global::System.Collections.Generic.IList<string>? SlidesMarkdown { get; set; }

        /// <summary>
        /// The layout for each slides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides_layout")]
        public global::System.Collections.Generic.IList<string>? SlidesLayout { get; set; }

        /// <summary>
        /// Number of slides to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_slides")]
        public int? NSlides { get; set; }

        /// <summary>
        /// The instruction for generating the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The tone to use for the text<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.ToneJsonConverter))]
        public global::Presenton.Tone? Tone { get; set; }

        /// <summary>
        /// How verbose the text should be<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.VerbosityJsonConverter))]
        public global::Presenton.Verbosity? Verbosity { get; set; }

        /// <summary>
        /// How to generate the content for each slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_generation")]
        public global::Presenton.ContentGenerationMode? ContentGeneration { get; set; }

        /// <summary>
        /// Whether to emphasize the markdown<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_emphasis")]
        public bool? MarkdownEmphasis { get; set; }

        /// <summary>
        /// Whether to enable web search<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// Type of image to generate<br/>
        /// Default Value: stock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV1ImageTypeJsonConverter))]
        public global::Presenton.GeneratePresentationRequestV1ImageType? ImageType { get; set; }

        /// <summary>
        /// Theme to use for the presentation. Available themes: edge-yellow, light-rose, mint-blue, professional-blue, professional-dark and your custom themes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public string? Theme { get; set; }

        /// <summary>
        /// Language for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Template to use for the presentation. Available templates: neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift and your custom templates<br/>
        /// Default Value: general
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// Whether to include a table of contents<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_table_of_contents")]
        public bool? IncludeTableOfContents { get; set; }

        /// <summary>
        /// Whether to include a title slide<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_title_slide")]
        public bool? IncludeTitleSlide { get; set; }

        /// <summary>
        /// Whether to allow access to user's info<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_access_to_user_info")]
        public bool? AllowAccessToUserInfo { get; set; }

        /// <summary>
        /// Files to use for the presentation. Use /api/v1/ppt/files/upload to upload files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// Export format<br/>
        /// Default Value: pptx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV1ExportAsJsonConverter))]
        public global::Presenton.GeneratePresentationRequestV1ExportAs? ExportAs { get; set; }

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
        /// Initializes a new instance of the <see cref="GeneratePresentationRequestV1" /> class.
        /// </summary>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="slidesMarkdown">
        /// The markdown for the slides
        /// </param>
        /// <param name="slidesLayout">
        /// The layout for each slides
        /// </param>
        /// <param name="nSlides">
        /// Number of slides to generate
        /// </param>
        /// <param name="instructions">
        /// The instruction for generating the presentation
        /// </param>
        /// <param name="tone">
        /// The tone to use for the text<br/>
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// How verbose the text should be<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="contentGeneration">
        /// How to generate the content for each slide
        /// </param>
        /// <param name="markdownEmphasis">
        /// Whether to emphasize the markdown<br/>
        /// Default Value: true
        /// </param>
        /// <param name="webSearch">
        /// Whether to enable web search<br/>
        /// Default Value: false
        /// </param>
        /// <param name="imageType">
        /// Type of image to generate<br/>
        /// Default Value: stock
        /// </param>
        /// <param name="theme">
        /// Theme to use for the presentation. Available themes: edge-yellow, light-rose, mint-blue, professional-blue, professional-dark and your custom themes
        /// </param>
        /// <param name="language">
        /// Language for the presentation
        /// </param>
        /// <param name="template">
        /// Template to use for the presentation. Available templates: neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift and your custom templates<br/>
        /// Default Value: general
        /// </param>
        /// <param name="includeTableOfContents">
        /// Whether to include a table of contents<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTitleSlide">
        /// Whether to include a title slide<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAccessToUserInfo">
        /// Whether to allow access to user's info<br/>
        /// Default Value: true
        /// </param>
        /// <param name="files">
        /// Files to use for the presentation. Use /api/v1/ppt/files/upload to upload files.
        /// </param>
        /// <param name="exportAs">
        /// Export format<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="triggerWebhook">
        /// Whether to trigger subscribed webhooks<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratePresentationRequestV1(
            string? content,
            global::System.Collections.Generic.IList<string>? slidesMarkdown,
            global::System.Collections.Generic.IList<string>? slidesLayout,
            int? nSlides,
            string? instructions,
            global::Presenton.Tone? tone,
            global::Presenton.Verbosity? verbosity,
            global::Presenton.ContentGenerationMode? contentGeneration,
            bool? markdownEmphasis,
            bool? webSearch,
            global::Presenton.GeneratePresentationRequestV1ImageType? imageType,
            string? theme,
            string? language,
            string? template,
            bool? includeTableOfContents,
            bool? includeTitleSlide,
            bool? allowAccessToUserInfo,
            global::System.Collections.Generic.IList<string>? files,
            global::Presenton.GeneratePresentationRequestV1ExportAs? exportAs,
            bool? triggerWebhook)
        {
            this.Content = content;
            this.SlidesMarkdown = slidesMarkdown;
            this.SlidesLayout = slidesLayout;
            this.NSlides = nSlides;
            this.Instructions = instructions;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.ContentGeneration = contentGeneration;
            this.MarkdownEmphasis = markdownEmphasis;
            this.WebSearch = webSearch;
            this.ImageType = imageType;
            this.Theme = theme;
            this.Language = language;
            this.Template = template;
            this.IncludeTableOfContents = includeTableOfContents;
            this.IncludeTitleSlide = includeTitleSlide;
            this.AllowAccessToUserInfo = allowAccessToUserInfo;
            this.Files = files;
            this.ExportAs = exportAs;
            this.TriggerWebhook = triggerWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePresentationRequestV1" /> class.
        /// </summary>
        public GeneratePresentationRequestV1()
        {
        }
    }
}