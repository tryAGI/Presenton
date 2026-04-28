#nullable enable

namespace Presenton
{
    public partial interface IHtmlCreateClient
    {
        /// <summary>
        /// Init Html Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditInitResponse> InitHtmlCreateApiV1PptHtmlCreateInitPostAsync(

            global::Presenton.BodyInitHtmlCreateApiV1PptHtmlCreateInitPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Html Create
        /// </summary>
        /// <param name="sketchImage">
        /// Primary reference/sketch image (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Primary reference/sketch image (optional)
        /// </param>
        /// <param name="additionalImages"></param>
        /// <param name="html">
        /// Optional existing HTML content to inform create
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the slide to create
        /// </param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide create
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditInitResponse> InitHtmlCreateApiV1PptHtmlCreateInitPostAsync(
            string prompt,
            byte[]? sketchImage = default,
            string? sketchImagename = default,
            global::System.Collections.Generic.IList<byte[]>? additionalImages = default,
            string? html = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}