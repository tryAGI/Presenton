
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterprisePresentationRead
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
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PresentationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Guid? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Enterprise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_slides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NSlides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FromApi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterprisePresentationRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="presentationId"></param>
        /// <param name="enterprise"></param>
        /// <param name="title"></param>
        /// <param name="nSlides"></param>
        /// <param name="version"></param>
        /// <param name="fromApi"></param>
        /// <param name="createdAt"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterprisePresentationRead(
            global::System.Guid id,
            global::System.Guid presentationId,
            string enterprise,
            string title,
            int nSlides,
            int version,
            bool fromApi,
            global::System.DateTime createdAt,
            global::System.Guid? user)
        {
            this.Id = id;
            this.PresentationId = presentationId;
            this.User = user;
            this.Enterprise = enterprise ?? throw new global::System.ArgumentNullException(nameof(enterprise));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.NSlides = nSlides;
            this.Version = version;
            this.FromApi = fromApi;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterprisePresentationRead" /> class.
        /// </summary>
        public EnterprisePresentationRead()
        {
        }
    }
}