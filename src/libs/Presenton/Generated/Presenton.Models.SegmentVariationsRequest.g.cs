
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentVariationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentVariationsRequest" /> class.
        /// </summary>
        /// <param name="segmentCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentVariationsRequest(
            string segmentCode)
        {
            this.SegmentCode = segmentCode ?? throw new global::System.ArgumentNullException(nameof(segmentCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentVariationsRequest" /> class.
        /// </summary>
        public SegmentVariationsRequest()
        {
        }
    }
}