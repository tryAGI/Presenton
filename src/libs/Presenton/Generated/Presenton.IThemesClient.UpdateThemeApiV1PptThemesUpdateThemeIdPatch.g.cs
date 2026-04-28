#nullable enable

namespace Presenton
{
    public partial interface IThemesClient
    {
        /// <summary>
        /// Update Theme
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationThemeModel> UpdateThemeApiV1PptThemesUpdateThemeIdPatchAsync(
            global::System.Guid themeId,

            global::Presenton.BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Theme
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="companyName"></param>
        /// <param name="logo"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationThemeModel> UpdateThemeApiV1PptThemesUpdateThemeIdPatchAsync(
            global::System.Guid themeId,
            string? name = default,
            string? description = default,
            string? companyName = default,
            global::System.Guid? logo = default,
            object? data = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}