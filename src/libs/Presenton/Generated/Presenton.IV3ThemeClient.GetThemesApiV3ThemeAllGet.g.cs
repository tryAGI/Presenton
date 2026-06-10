#nullable enable

namespace Presenton
{
    public partial interface IV3ThemeClient
    {
        /// <summary>
        /// List user themes<br/>
        /// Returns the authenticated user's custom presentation themes ordered by newest first. Built-in default themes are not included in this list.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Presenton.PresentationThemeResponse>> GetThemesApiV3ThemeAllGetAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List user themes<br/>
        /// Returns the authenticated user's custom presentation themes ordered by newest first. Built-in default themes are not included in this list.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Presenton.PresentationThemeResponse>>> GetThemesApiV3ThemeAllGetAsResponseAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}