
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsRate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("below_25_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Below25Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("below_50_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Below50Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("below_100_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Below100Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("above_100_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Above100Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsRate" /> class.
        /// </summary>
        /// <param name="below25Cost"></param>
        /// <param name="below50Cost"></param>
        /// <param name="below100Cost"></param>
        /// <param name="above100Cost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsRate(
            double below25Cost,
            double below50Cost,
            double below100Cost,
            double above100Cost)
        {
            this.Below25Cost = below25Cost;
            this.Below50Cost = below50Cost;
            this.Below100Cost = below100Cost;
            this.Above100Cost = above100Cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsRate" /> class.
        /// </summary>
        public CreditsRate()
        {
        }
    }
}