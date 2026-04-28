
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratePresentationRequestV2
    {
        /// <summary>
        /// The content for generating the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The content for the each slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        public global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>? Slides { get; set; }

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
        /// Smart design to use for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_design")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SmartDesign { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV2ImageTypeJsonConverter))]
        public global::Presenton.GeneratePresentationRequestV2ImageType? ImageType { get; set; }

        /// <summary>
        /// Language for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV2ExportAsJsonConverter))]
        public global::Presenton.GeneratePresentationRequestV2ExportAs? ExportAs { get; set; }

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
        /// Initializes a new instance of the <see cref="GeneratePresentationRequestV2" /> class.
        /// </summary>
        /// <param name="smartDesign">
        /// Smart design to use for the presentation
        /// </param>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="slides">
        /// The content for the each slide
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
        /// <param name="language">
        /// Language for the presentation
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
        public GeneratePresentationRequestV2(
            string smartDesign,
            string? content,
            global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>? slides,
            int? nSlides,
            string? instructions,
            global::Presenton.Tone? tone,
            global::Presenton.Verbosity? verbosity,
            global::Presenton.ContentGenerationMode? contentGeneration,
            bool? markdownEmphasis,
            bool? webSearch,
            global::Presenton.GeneratePresentationRequestV2ImageType? imageType,
            string? language,
            bool? includeTableOfContents,
            bool? includeTitleSlide,
            bool? allowAccessToUserInfo,
            global::System.Collections.Generic.IList<string>? files,
            global::Presenton.GeneratePresentationRequestV2ExportAs? exportAs,
            bool? triggerWebhook)
        {
            this.Content = content;
            this.Slides = slides;
            this.NSlides = nSlides;
            this.Instructions = instructions;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.ContentGeneration = contentGeneration;
            this.SmartDesign = smartDesign ?? throw new global::System.ArgumentNullException(nameof(smartDesign));
            this.MarkdownEmphasis = markdownEmphasis;
            this.WebSearch = webSearch;
            this.ImageType = imageType;
            this.Language = language;
            this.IncludeTableOfContents = includeTableOfContents;
            this.IncludeTitleSlide = includeTitleSlide;
            this.AllowAccessToUserInfo = allowAccessToUserInfo;
            this.Files = files;
            this.ExportAs = exportAs;
            this.TriggerWebhook = triggerWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePresentationRequestV2" /> class.
        /// </summary>
        public GeneratePresentationRequestV2()
        {
        }
    }
}