
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PdfSlidesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.PdfSlideData> Slides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSlides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSlidesResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="slides"></param>
        /// <param name="totalSlides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PdfSlidesResponse(
            bool success,
            global::System.Collections.Generic.IList<global::Presenton.PdfSlideData> slides,
            int totalSlides)
        {
            this.Success = success;
            this.Slides = slides ?? throw new global::System.ArgumentNullException(nameof(slides));
            this.TotalSlides = totalSlides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSlidesResponse" /> class.
        /// </summary>
        public PdfSlidesResponse()
        {
        }
    }
}