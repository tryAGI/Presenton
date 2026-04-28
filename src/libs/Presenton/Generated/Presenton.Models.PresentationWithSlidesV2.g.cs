
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentationWithSlidesV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_slides")]
        public int? NSlides { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_system_id")]
        public global::System.Guid? DesignSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fonts")]
        public object? Fonts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.HTMLSlideV2> Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationWithSlidesV2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="slides"></param>
        /// <param name="title"></param>
        /// <param name="nSlides"></param>
        /// <param name="tone"></param>
        /// <param name="verbosity"></param>
        /// <param name="language"></param>
        /// <param name="designSystemId"></param>
        /// <param name="fonts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentationWithSlidesV2(
            global::System.Guid id,
            global::System.Guid user,
            global::System.Collections.Generic.IList<global::Presenton.HTMLSlideV2> slides,
            string? title,
            int? nSlides,
            string? tone,
            string? verbosity,
            string? language,
            global::System.Guid? designSystemId,
            object? fonts)
        {
            this.Id = id;
            this.User = user;
            this.Title = title;
            this.NSlides = nSlides;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.Language = language;
            this.DesignSystemId = designSystemId;
            this.Fonts = fonts;
            this.Slides = slides ?? throw new global::System.ArgumentNullException(nameof(slides));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationWithSlidesV2" /> class.
        /// </summary>
        public PresentationWithSlidesV2()
        {
        }
    }
}