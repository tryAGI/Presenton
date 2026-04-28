
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateOutlinesRequest
    {
        /// <summary>
        /// The content for generating the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The files to use for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// The number of slides to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_slides")]
        public int? NSlides { get; set; }

        /// <summary>
        /// The language for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The tone for the presentation<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.ToneJsonConverter))]
        public global::Presenton.Tone? Tone { get; set; }

        /// <summary>
        /// The verbosity for the presentation<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.VerbosityJsonConverter))]
        public global::Presenton.Verbosity? Verbosity { get; set; }

        /// <summary>
        /// The content generation mode for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_generation")]
        public global::Presenton.ContentGenerationMode? ContentGeneration { get; set; }

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
        /// The instructions for the presentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateOutlinesRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="files">
        /// The files to use for the presentation
        /// </param>
        /// <param name="nSlides">
        /// The number of slides to generate
        /// </param>
        /// <param name="language">
        /// The language for the presentation
        /// </param>
        /// <param name="tone">
        /// The tone for the presentation<br/>
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// The verbosity for the presentation<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="contentGeneration">
        /// The content generation mode for the presentation
        /// </param>
        /// <param name="includeTitleSlide">
        /// Whether to include a title slide<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAccessToUserInfo">
        /// Whether to allow access to user's info<br/>
        /// Default Value: true
        /// </param>
        /// <param name="instructions">
        /// The instructions for the presentation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateOutlinesRequest(
            string? content,
            global::System.Collections.Generic.IList<string>? files,
            int? nSlides,
            string? language,
            global::Presenton.Tone? tone,
            global::Presenton.Verbosity? verbosity,
            global::Presenton.ContentGenerationMode? contentGeneration,
            bool? includeTitleSlide,
            bool? allowAccessToUserInfo,
            string? instructions)
        {
            this.Content = content;
            this.Files = files;
            this.NSlides = nSlides;
            this.Language = language;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.ContentGeneration = contentGeneration;
            this.IncludeTitleSlide = includeTitleSlide;
            this.AllowAccessToUserInfo = allowAccessToUserInfo;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateOutlinesRequest" /> class.
        /// </summary>
        public GenerateOutlinesRequest()
        {
        }
    }
}