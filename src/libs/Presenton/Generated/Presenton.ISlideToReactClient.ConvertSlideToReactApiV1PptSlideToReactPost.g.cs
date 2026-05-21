#nullable enable

namespace Presenton
{
    public partial interface ISlideToReactClient
    {
        /// <summary>
        /// Convert Slide To React
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SlideToReactResponse> ConvertSlideToReactApiV1PptSlideToReactPostAsync(

            global::Presenton.SlideToReactRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Slide To React
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.SlideToReactResponse>> ConvertSlideToReactApiV1PptSlideToReactPostAsResponseAsync(

            global::Presenton.SlideToReactRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Slide To React
        /// </summary>
        /// <param name="image"></param>
        /// <param name="markdownContent"></param>
        /// <param name="designSystem"></param>
        /// <param name="fonts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SlideToReactResponse> ConvertSlideToReactApiV1PptSlideToReactPostAsync(
            string image,
            string markdownContent,
            object designSystem,
            global::System.Collections.Generic.IList<string>? fonts = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}