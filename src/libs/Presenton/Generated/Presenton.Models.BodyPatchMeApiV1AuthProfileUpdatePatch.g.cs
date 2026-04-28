
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPatchMeApiV1AuthProfileUpdatePatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        public byte[]? ProfilePicture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picturename")]
        public string? ProfilePicturename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchMeApiV1AuthProfileUpdatePatch" /> class.
        /// </summary>
        /// <param name="profilePicture"></param>
        /// <param name="profilePicturename"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyPatchMeApiV1AuthProfileUpdatePatch(
            byte[]? profilePicture,
            string? profilePicturename,
            string? name)
        {
            this.ProfilePicture = profilePicture;
            this.ProfilePicturename = profilePicturename;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchMeApiV1AuthProfileUpdatePatch" /> class.
        /// </summary>
        public BodyPatchMeApiV1AuthProfileUpdatePatch()
        {
        }
    }
}