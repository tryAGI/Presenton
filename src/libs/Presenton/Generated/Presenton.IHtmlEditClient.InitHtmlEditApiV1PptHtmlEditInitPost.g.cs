#nullable enable

namespace Presenton
{
    public partial interface IHtmlEditClient
    {
        /// <summary>
        /// Init Html Edit
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditInitResponse> InitHtmlEditApiV1PptHtmlEditInitPostAsync(

            global::Presenton.BodyInitHtmlEditApiV1PptHtmlEditInitPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Html Edit
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlEditInitResponse>> InitHtmlEditApiV1PptHtmlEditInitPostAsResponseAsync(

            global::Presenton.BodyInitHtmlEditApiV1PptHtmlEditInitPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Html Edit
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="additionalImages"></param>
        /// <param name="html">
        /// Current HTML content to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide edits
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditInitResponse> InitHtmlEditApiV1PptHtmlEditInitPostAsync(
            byte[] currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            byte[]? sketchImage = default,
            string? sketchImagename = default,
            global::System.Collections.Generic.IList<byte[]>? additionalImages = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Init Html Edit
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="additionalImages"></param>
        /// <param name="html">
        /// Current HTML content to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide edits
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditInitResponse> InitHtmlEditApiV1PptHtmlEditInitPostAsync(
            global::System.IO.Stream currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            global::System.IO.Stream? sketchImage = default,
            string? sketchImagename = default,
            global::System.Collections.Generic.IList<byte[]>? additionalImages = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Html Edit
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="additionalImages"></param>
        /// <param name="html">
        /// Current HTML content to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide edits
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlEditInitResponse>> InitHtmlEditApiV1PptHtmlEditInitPostAsResponseAsync(
            global::System.IO.Stream currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            global::System.IO.Stream? sketchImage = default,
            string? sketchImagename = default,
            global::System.Collections.Generic.IList<byte[]>? additionalImages = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}