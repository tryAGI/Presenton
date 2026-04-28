
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateHTMLPresentationRequestV2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DesignId { get; set; }

        /// <summary>
        /// Default Value: ai-generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Presenton.JsonConverters.GenerateHTMLPresentationRequestV2ImageTypeJsonConverter))]
        public global::Presenton.GenerateHTMLPresentationRequestV2ImageType? ImageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_paths")]
        public global::System.Collections.Generic.IList<string>? FilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHTMLPresentationRequestV2" /> class.
        /// </summary>
        /// <param name="designId"></param>
        /// <param name="content"></param>
        /// <param name="nSlides"></param>
        /// <param name="language"></param>
        /// <param name="tone">
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// Default Value: standard
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="webSearch">
        /// Default Value: false
        /// </param>
        /// <param name="imageType">
        /// Default Value: ai-generated
        /// </param>
        /// <param name="filePaths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateHTMLPresentationRequestV2(
            global::System.Guid designId,
            string? content,
            int? nSlides,
            string? language,
            global::Presenton.Tone? tone,
            global::Presenton.Verbosity? verbosity,
            string? instructions,
            bool? webSearch,
            global::Presenton.GenerateHTMLPresentationRequestV2ImageType? imageType,
            global::System.Collections.Generic.IList<string>? filePaths)
        {
            this.Content = content;
            this.NSlides = nSlides;
            this.Language = language;
            this.Tone = tone;
            this.Verbosity = verbosity;
            this.Instructions = instructions;
            this.WebSearch = webSearch;
            this.DesignId = designId;
            this.ImageType = imageType;
            this.FilePaths = filePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHTMLPresentationRequestV2" /> class.
        /// </summary>
        public GenerateHTMLPresentationRequestV2()
        {
        }
    }
}