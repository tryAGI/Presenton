
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresentationSummaryResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("presentations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Presenton.PresentationSummary> Presentations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_presentations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPresentations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_layouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalLayouts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentationSummaryResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="presentations"></param>
        /// <param name="totalPresentations"></param>
        /// <param name="totalLayouts"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPresentationSummaryResponse(
            bool success,
            global::System.Collections.Generic.IList<global::Presenton.PresentationSummary> presentations,
            int totalPresentations,
            int totalLayouts,
            string? message)
        {
            this.Success = success;
            this.Presentations = presentations ?? throw new global::System.ArgumentNullException(nameof(presentations));
            this.TotalPresentations = totalPresentations;
            this.TotalLayouts = totalLayouts;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentationSummaryResponse" /> class.
        /// </summary>
        public GetPresentationSummaryResponse()
        {
        }
    }
}