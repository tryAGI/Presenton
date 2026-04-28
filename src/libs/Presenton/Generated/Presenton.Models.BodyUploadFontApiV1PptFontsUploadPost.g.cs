
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFontApiV1PptFontsUploadPost
    {
        /// <summary>
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFontApiV1PptFontsUploadPost" /> class.
        /// </summary>
        /// <param name="file">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="filename">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFontApiV1PptFontsUploadPost(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFontApiV1PptFontsUploadPost" /> class.
        /// </summary>
        public BodyUploadFontApiV1PptFontsUploadPost()
        {
        }
    }
}