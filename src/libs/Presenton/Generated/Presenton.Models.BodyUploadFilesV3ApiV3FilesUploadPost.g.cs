
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFilesV3ApiV3FilesUploadPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFilesV3ApiV3FilesUploadPost" /> class.
        /// </summary>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFilesV3ApiV3FilesUploadPost(
            global::System.Collections.Generic.IList<byte[]>? files)
        {
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFilesV3ApiV3FilesUploadPost" /> class.
        /// </summary>
        public BodyUploadFilesV3ApiV3FilesUploadPost()
        {
        }
    }
}