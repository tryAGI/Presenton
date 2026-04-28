
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThemeData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Primary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stroke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimaryText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_0")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_3")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_4")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_5")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_6")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_7")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_8")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_9")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Graph9 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeData" /> class.
        /// </summary>
        /// <param name="primary"></param>
        /// <param name="background"></param>
        /// <param name="card"></param>
        /// <param name="stroke"></param>
        /// <param name="primaryText"></param>
        /// <param name="backgroundText"></param>
        /// <param name="graph0"></param>
        /// <param name="graph1"></param>
        /// <param name="graph2"></param>
        /// <param name="graph3"></param>
        /// <param name="graph4"></param>
        /// <param name="graph5"></param>
        /// <param name="graph6"></param>
        /// <param name="graph7"></param>
        /// <param name="graph8"></param>
        /// <param name="graph9"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThemeData(
            string primary,
            string background,
            string card,
            string stroke,
            string primaryText,
            string backgroundText,
            string graph0,
            string graph1,
            string graph2,
            string graph3,
            string graph4,
            string graph5,
            string graph6,
            string graph7,
            string graph8,
            string graph9)
        {
            this.Primary = primary ?? throw new global::System.ArgumentNullException(nameof(primary));
            this.Background = background ?? throw new global::System.ArgumentNullException(nameof(background));
            this.Card = card ?? throw new global::System.ArgumentNullException(nameof(card));
            this.Stroke = stroke ?? throw new global::System.ArgumentNullException(nameof(stroke));
            this.PrimaryText = primaryText ?? throw new global::System.ArgumentNullException(nameof(primaryText));
            this.BackgroundText = backgroundText ?? throw new global::System.ArgumentNullException(nameof(backgroundText));
            this.Graph0 = graph0 ?? throw new global::System.ArgumentNullException(nameof(graph0));
            this.Graph1 = graph1 ?? throw new global::System.ArgumentNullException(nameof(graph1));
            this.Graph2 = graph2 ?? throw new global::System.ArgumentNullException(nameof(graph2));
            this.Graph3 = graph3 ?? throw new global::System.ArgumentNullException(nameof(graph3));
            this.Graph4 = graph4 ?? throw new global::System.ArgumentNullException(nameof(graph4));
            this.Graph5 = graph5 ?? throw new global::System.ArgumentNullException(nameof(graph5));
            this.Graph6 = graph6 ?? throw new global::System.ArgumentNullException(nameof(graph6));
            this.Graph7 = graph7 ?? throw new global::System.ArgumentNullException(nameof(graph7));
            this.Graph8 = graph8 ?? throw new global::System.ArgumentNullException(nameof(graph8));
            this.Graph9 = graph9 ?? throw new global::System.ArgumentNullException(nameof(graph9));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeData" /> class.
        /// </summary>
        public ThemeData()
        {
        }
    }
}