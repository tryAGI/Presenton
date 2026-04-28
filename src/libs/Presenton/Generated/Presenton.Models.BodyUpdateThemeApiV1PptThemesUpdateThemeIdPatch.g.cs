
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public global::System.Guid? Logo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="companyName"></param>
        /// <param name="logo"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch(
            string? name,
            string? description,
            string? companyName,
            global::System.Guid? logo,
            object? data)
        {
            this.Name = name;
            this.Description = description;
            this.CompanyName = companyName;
            this.Logo = logo;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch" /> class.
        /// </summary>
        public BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch()
        {
        }
    }
}