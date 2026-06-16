#nullable enable

namespace Presenton
{
    public partial interface IV3ThemeClient
    {
        /// <summary>
        /// Update a user theme<br/>
        /// Updates a custom theme owned by the authenticated user. Fields are optional; only supplied values are changed. Passing a new `logo` replaces the previous logo asset, and passing `data` replaces the stored colors and fonts.
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationThemeResponse> UpdateThemeApiV3ThemeUpdateThemeIdPatchAsync(
            global::System.Guid themeId,

            global::Presenton.BodyUpdateThemeApiV3ThemeUpdateThemeIdPatch request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user theme<br/>
        /// Updates a custom theme owned by the authenticated user. Fields are optional; only supplied values are changed. Passing a new `logo` replaces the previous logo asset, and passing `data` replaces the stored colors and fonts.
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PresentationThemeResponse>> UpdateThemeApiV3ThemeUpdateThemeIdPatchAsResponseAsync(
            global::System.Guid themeId,

            global::Presenton.BodyUpdateThemeApiV3ThemeUpdateThemeIdPatch request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user theme<br/>
        /// Updates a custom theme owned by the authenticated user. Fields are optional; only supplied values are changed. Passing a new `logo` replaces the previous logo asset, and passing `data` replaces the stored colors and fonts.
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
        global::System.Threading.Tasks.Task<global::Presenton.PresentationThemeResponse> UpdateThemeApiV3ThemeUpdateThemeIdPatchAsync(
            global::System.Guid themeId,
            string? name = default,
            string? description = default,
            string? companyName = default,
            global::System.Guid? logo = default,
            global::Presenton.PresentionThemeDataInput? data = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}