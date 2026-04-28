
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentationModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Guid? User { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_paths")]
        public global::System.Collections.Generic.IList<string>? FilePaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outlines")]
        public object? Outlines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        public object? Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure")]
        public object? Structure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        public string? Tone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        public string? Verbosity { get; set; }

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
        public string? ImageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public object? Theme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_playground")]
        public bool? FromPlayground { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationModel" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="content"></param>
        /// <param name="nSlides"></param>
        /// <param name="language"></param>
        /// <param name="title"></param>
        /// <param name="filePaths"></param>
        /// <param name="outlines"></param>
        /// <param name="layout"></param>
        /// <param name="structure"></param>
        /// <param name="instructions"></param>
        /// <param name="tone"></param>
        /// <param name="verbosity"></param>
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
        /// <param name="theme"></param>
        /// <param name="fromPlayground"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentationModel(
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Guid? id,
            global::System.Guid? user,
            string? content,
            int? nSlides,
            string? language,
            string? title,
            global::System.Collections.Generic.IList<string>? filePaths,
            object? outlines,
            object? layout,
            object? structure,
            string? instructions,
            string? tone,
            string? verbosity,
            bool? includeTableOfContents,
            bool? includeTitleSlide,
            bool? webSearch,
            string? imageType,
            object? theme,
            bool? fromPlayground)
        {
            this.Id = id;
            this.User = user;
            this.Content = content;
            this.NSlides = nSlides;
            this.Language = language;
            this.Title = title;
            this.FilePaths = filePaths;
            this.Outlines = outlines;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Layout = layout;
            this.Structure = structure;
            this.Instructions = instructions;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.IncludeTableOfContents = includeTableOfContents;
            this.IncludeTitleSlide = includeTitleSlide;
            this.WebSearch = webSearch;
            this.ImageType = imageType;
            this.Theme = theme;
            this.FromPlayground = fromPlayground;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationModel" /> class.
        /// </summary>
        public PresentationModel()
        {
        }
    }
}