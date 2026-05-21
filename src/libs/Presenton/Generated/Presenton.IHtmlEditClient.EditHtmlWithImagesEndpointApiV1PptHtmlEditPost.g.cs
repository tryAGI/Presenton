#nullable enable

namespace Presenton
{
    public partial interface IHtmlEditClient
    {
        /// <summary>
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync(

            global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlEditResponse>> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsResponseAsync(

            global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
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
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync(
            byte[] currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            byte[]? sketchImage = default,
            string? sketchImagename = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
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
        global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync(
            global::System.IO.Stream currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            global::System.IO.Stream? sketchImage = default,
            string? sketchImagename = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
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
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlEditResponse>> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsResponseAsync(
            global::System.IO.Stream currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            global::System.IO.Stream? sketchImage = default,
            string? sketchImagename = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}