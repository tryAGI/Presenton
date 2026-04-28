
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresentationStatusResponseV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Slides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentationStatusResponseV2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="slides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPresentationStatusResponseV2(
            string status,
            int slides)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Slides = slides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentationStatusResponseV2" /> class.
        /// </summary>
        public GetPresentationStatusResponseV2()
        {
        }
    }
}