#nullable enable

namespace Presenton
{
    public partial interface IThemesClient
    {
        /// <summary>
        /// Delete a user theme<br/>
        /// Deletes a custom theme owned by the authenticated user. Default built-in themes cannot be deleted through this endpoint.
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteThemeApiV1PptThemesDeleteThemeIdDeleteAsync(
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
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse> DeleteThemeApiV1PptThemesDeleteThemeIdDeleteAsResponseAsync(
            global::System.Guid themeId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}