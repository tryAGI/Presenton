
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePresentationApiV1PptPresentationCreatePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_slides")]
        public int? NSlides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_paths")]
        public global::System.Collections.Generic.IList<string>? FilePaths { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.ToneJsonConverter))]
        public global::Presenton.Tone? Tone { get; set; }

        /// <summary>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.VerbosityJsonConverter))]
        public global::Presenton.Verbosity? Verbosity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_table_of_contents")]
        public bool? IncludeTableOfContents { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_title_slide")]
        public bool? IncludeTitleSlide { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// Default Value: stock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.BodyCreatePresentationApiV1PptPresentationCreatePostImageTypeJsonConverter))]
        public global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePostImageType? ImageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePresentationApiV1PptPresentationCreatePost" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="nSlides"></param>
        /// <param name="language"></param>
        /// <param name="filePaths"></param>
        /// <param name="tone">
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// Default Value: standard
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="includeTableOfContents">
        /// Default Value: false
        /// </param>
        /// <param name="includeTitleSlide">
        /// Default Value: true
        /// </param>
        /// <param name="webSearch">
        /// Default Value: false
        /// </param>
        /// <param name="imageType">
        /// Default Value: stock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreatePresentationApiV1PptPresentationCreatePost(
            string? content,
            int? nSlides,
            string? language,
            global::System.Collections.Generic.IList<string>? filePaths,
            global::Presenton.Tone? tone,
            global::Presenton.Verbosity? verbosity,
            string? instructions,
            bool? includeTableOfContents,
            bool? includeTitleSlide,
            bool? webSearch,
            global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePostImageType? imageType)
        {
            this.Content = content;
            this.NSlides = nSlides;
            this.Language = language;
            this.FilePaths = filePaths;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.Instructions = instructions;
            this.IncludeTableOfContents = includeTableOfContents;
            this.IncludeTitleSlide = includeTitleSlide;
            this.WebSearch = webSearch;
            this.ImageType = imageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePresentationApiV1PptPresentationCreatePost" /> class.
        /// </summary>
        public BodyCreatePresentationApiV1PptPresentationCreatePost()
        {
        }
    }
}