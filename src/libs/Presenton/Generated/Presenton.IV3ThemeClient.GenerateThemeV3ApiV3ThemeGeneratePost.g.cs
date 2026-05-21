#nullable enable

namespace Presenton
{
    public partial interface IV3ThemeClient
    {
        /// <summary>
        /// Generate Theme V3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ThemeData> GenerateThemeV3ApiV3ThemeGeneratePostAsync(

            global::Presenton.GenerateThemeRequestV3 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Theme V3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.ThemeData>> GenerateThemeV3ApiV3ThemeGeneratePostAsResponseAsync(

            global::Presenton.GenerateThemeRequestV3 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Theme V3
        /// </summary>
        /// <param name="primary"></param>
        /// <param name="background"></param>
        /// <param name="accent1"></param>
        /// <param name="accent2"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ThemeData> GenerateThemeV3ApiV3ThemeGeneratePostAsync(
            string? primary = default,
            string? background = default,
            string? accent1 = default,
            string? accent2 = default,
            string? text1 = default,
            string? text2 = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}