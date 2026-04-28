
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePresentationRequestV2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        public global::System.Collections.Generic.IList<global::Presenton.HTMLSlideV2>? Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresentationRequestV2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nSlides"></param>
        /// <param name="title"></param>
        /// <param name="slides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePresentationRequestV2(
            global::System.Guid id,
            int? nSlides,
            string? title,
            global::System.Collections.Generic.IList<global::Presenton.HTMLSlideV2>? slides)
        {
            this.Id = id;
            this.NSlides = nSlides;
            this.Title = title;
            this.Slides = slides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresentationRequestV2" /> class.
        /// </summary>
        public UpdatePresentationRequestV2()
        {
        }
    }
}