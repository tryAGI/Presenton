
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFilesV1ApiV1PptFilesUploadPost
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
        /// Initializes a new instance of the <see cref="BodyUploadFilesV1ApiV1PptFilesUploadPost" /> class.
        /// </summary>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFilesV1ApiV1PptFilesUploadPost(
            global::System.Collections.Generic.IList<byte[]>? files)
        {
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFilesV1ApiV1PptFilesUploadPost" /> class.
        /// </summary>
        public BodyUploadFilesV1ApiV1PptFilesUploadPost()
        {
        }
    }
}