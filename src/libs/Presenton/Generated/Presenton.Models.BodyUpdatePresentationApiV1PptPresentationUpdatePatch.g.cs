
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdatePresentationApiV1PptPresentationUpdatePatch
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
        [global::System.Text.Json.Serialization.JsonPropertyName("n_slides")]
        public int? NSlides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public object? Theme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        public global::System.Collections.Generic.IList<global::Presenton.SlideModel>? Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePresentationApiV1PptPresentationUpdatePatch" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nSlides"></param>
        /// <param name="title"></param>
        /// <param name="theme"></param>
        /// <param name="slides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdatePresentationApiV1PptPresentationUpdatePatch(
            global::System.Guid id,
            int? nSlides,
            string? title,
            object? theme,
            global::System.Collections.Generic.IList<global::Presenton.SlideModel>? slides)
        {
            this.Id = id;
            this.NSlides = nSlides;
            this.Title = title;
            this.Theme = theme;
            this.Slides = slides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePresentationApiV1PptPresentationUpdatePatch" /> class.
        /// </summary>
        public BodyUpdatePresentationApiV1PptPresentationUpdatePatch()
        {
        }
    }
}