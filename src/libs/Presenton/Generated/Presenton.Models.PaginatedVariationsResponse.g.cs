
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedVariationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_prev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPrev { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedVariationsResponse" /> class.
        /// </summary>
        /// <param name="variations"></param>
        /// <param name="total"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="totalPages"></param>
        /// <param name="hasNext"></param>
        /// <param name="hasPrev"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedVariationsResponse(
            global::System.Collections.Generic.IList<string> variations,
            int total,
            int page,
            int count,
            int totalPages,
            bool hasNext,
            bool hasPrev)
        {
            this.Variations = variations ?? throw new global::System.ArgumentNullException(nameof(variations));
            this.Total = total;
            this.Page = page;
            this.Count = count;
            this.TotalPages = totalPages;
            this.HasNext = hasNext;
            this.HasPrev = hasPrev;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedVariationsResponse" /> class.
        /// </summary>
        public PaginatedVariationsResponse()
        {
        }
    }
}