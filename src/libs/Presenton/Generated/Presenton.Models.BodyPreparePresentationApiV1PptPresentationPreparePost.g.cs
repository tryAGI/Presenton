
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPreparePresentationApiV1PptPresentationPreparePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outlines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.SlideOutlineModel> Outlines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.PresentationLayoutModel Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPreparePresentationApiV1PptPresentationPreparePost" /> class.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="outlines"></param>
        /// <param name="layout"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyPreparePresentationApiV1PptPresentationPreparePost(
            global::System.Guid presentationId,
            global::System.Collections.Generic.IList<global::Presenton.SlideOutlineModel> outlines,
            global::Presenton.PresentationLayoutModel layout,
            string? title)
        {
            this.PresentationId = presentationId;
            this.Outlines = outlines ?? throw new global::System.ArgumentNullException(nameof(outlines));
            this.Layout = layout ?? throw new global::System.ArgumentNullException(nameof(layout));
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPreparePresentationApiV1PptPresentationPreparePost" /> class.
        /// </summary>
        public BodyPreparePresentationApiV1PptPresentationPreparePost()
        {
        }
    }
}