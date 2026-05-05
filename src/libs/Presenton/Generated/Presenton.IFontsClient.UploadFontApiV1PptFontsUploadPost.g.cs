#nullable enable

namespace Presenton
{
    public partial interface IFontsClient
    {
        /// <summary>
        /// Upload Font
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontDetail> UploadFontApiV1PptFontsUploadPostAsync(

            global::Presenton.BodyUploadFontApiV1PptFontsUploadPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Font
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontDetail>> UploadFontApiV1PptFontsUploadPostAsResponseAsync(

            global::Presenton.BodyUploadFontApiV1PptFontsUploadPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Font
        /// </summary>
        /// <param name="file">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="filename">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontDetail> UploadFontApiV1PptFontsUploadPostAsync(
            byte[] file,
            string filename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Font
        /// </summary>
        /// <param name="file">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="filename">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontDetail> UploadFontApiV1PptFontsUploadPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Font
        /// </summary>
        /// <param name="file">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="filename">
        /// Font file to upload (.ttf, .otf, .woff, .woff2, .eot)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontDetail>> UploadFontApiV1PptFontsUploadPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}