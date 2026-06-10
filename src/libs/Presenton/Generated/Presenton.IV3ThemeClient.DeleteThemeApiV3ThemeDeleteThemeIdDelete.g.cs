#nullable enable

namespace Presenton
{
    public partial interface IV3ThemeClient
    {
        /// <summary>
        /// Delete a user theme<br/>
        /// Deletes a custom theme owned by the authenticated user. Default built-in themes cannot be deleted through this endpoint.
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteThemeApiV3ThemeDeleteThemeIdDeleteAsync(
            global::System.Guid themeId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a user theme<br/>
        /// Deletes a custom theme owned by the authenticated user. Default built-in themes cannot be deleted through this endpoint.
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse> DeleteThemeApiV3ThemeDeleteThemeIdDeleteAsResponseAsync(
            global::System.Guid themeId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}