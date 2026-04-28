
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageAsset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Guid? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_uploaded")]
        public bool? IsUploaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAsset" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="isUploaded">
        /// Default Value: false
        /// </param>
        /// <param name="extras"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageAsset(
            global::System.DateTime createdAt,
            string path,
            global::System.Guid? id,
            global::System.Guid? user,
            bool? isUploaded,
            object? extras,
            string? url)
        {
            this.Id = id;
            this.User = user;
            this.CreatedAt = createdAt;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.IsUploaded = isUploaded;
            this.Extras = extras;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAsset" /> class.
        /// </summary>
        public ImageAsset()
        {
        }
    }
}