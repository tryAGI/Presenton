#nullable enable

namespace Presenton
{
    public partial interface IReactEditClient
    {
        /// <summary>
        /// Edit React With Image Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditReactWithImageEndpointApiV1PptReactEditPostAsync(

            global::Presenton.BodyEditReactWithImageEndpointApiV1PptReactEditPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit React With Image Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlEditResponse>> EditReactWithImageEndpointApiV1PptReactEditPostAsResponseAsync(

            global::Presenton.BodyEditReactWithImageEndpointApiV1PptReactEditPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit React With Image Endpoint
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="react">
        /// Current React component code to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="designSystem">
        /// Optional design system JSON to guide the edit
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditReactWithImageEndpointApiV1PptReactEditPostAsync(
            string react,
            string prompt,
            byte[]? currentUiImage = default,
            string? currentUiImagename = default,
            byte[]? sketchImage = default,
            string? sketchImagename = default,
            string? designSystem = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit React With Image Endpoint
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="react">
        /// Current React component code to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="designSystem">
        /// Optional design system JSON to guide the edit
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditReactWithImageEndpointApiV1PptReactEditPostAsync(
            string react,
            string prompt,
            global::System.IO.Stream? currentUiImage = default,
            string? currentUiImagename = default,
            global::System.IO.Stream? sketchImage = default,
            string? sketchImagename = default,
            string? designSystem = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit React With Image Endpoint
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file (optional)
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="react">
        /// Current React component code to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="designSystem">
        /// Optional design system JSON to guide the edit
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlEditResponse>> EditReactWithImageEndpointApiV1PptReactEditPostAsResponseAsync(
            string react,
            string prompt,
            global::System.IO.Stream? currentUiImage = default,
            string? currentUiImagename = default,
            global::System.IO.Stream? sketchImage = default,
            string? sketchImagename = default,
            string? designSystem = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}