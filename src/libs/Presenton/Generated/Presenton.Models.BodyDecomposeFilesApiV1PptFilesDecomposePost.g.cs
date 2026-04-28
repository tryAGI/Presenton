
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDecomposeFilesApiV1PptFilesDecomposePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDecomposeFilesApiV1PptFilesDecomposePost" /> class.
        /// </summary>
        /// <param name="filePaths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDecomposeFilesApiV1PptFilesDecomposePost(
            global::System.Collections.Generic.IList<string> filePaths)
        {
            this.FilePaths = filePaths ?? throw new global::System.ArgumentNullException(nameof(filePaths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDecomposeFilesApiV1PptFilesDecomposePost" /> class.
        /// </summary>
        public BodyDecomposeFilesApiV1PptFilesDecomposePost()
        {
        }
    }
}