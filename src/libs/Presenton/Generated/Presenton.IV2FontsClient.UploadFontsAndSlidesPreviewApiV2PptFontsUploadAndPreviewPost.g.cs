#nullable enable

namespace Presenton
{
    public partial interface IV2FontsClient
    {
        /// <summary>
        /// Upload Fonts And Slides Preview
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontsUploadAndSlidesPreviewResponse> UploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPostAsync(

            global::Presenton.BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Fonts And Slides Preview
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontsUploadAndSlidesPreviewResponse>> UploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPostAsResponseAsync(

            global::Presenton.BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Fonts And Slides Preview
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to modify
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to modify
        /// </param>
        /// <param name="fontFiles">
        /// Font files to upload
        /// </param>
        /// <param name="originalFontNames">
        /// Original font names to replace (same order as font_files)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontsUploadAndSlidesPreviewResponse> UploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPostAsync(
            byte[] pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fontFiles = default,
            global::System.Collections.Generic.IList<string>? originalFontNames = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Fonts And Slides Preview
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to modify
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to modify
        /// </param>
        /// <param name="fontFiles">
        /// Font files to upload
        /// </param>
        /// <param name="originalFontNames">
        /// Original font names to replace (same order as font_files)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontsUploadAndSlidesPreviewResponse> UploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPostAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fontFiles = default,
            global::System.Collections.Generic.IList<string>? originalFontNames = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Fonts And Slides Preview
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to modify
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to modify
        /// </param>
        /// <param name="fontFiles">
        /// Font files to upload
        /// </param>
        /// <param name="originalFontNames">
        /// Original font names to replace (same order as font_files)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontsUploadAndSlidesPreviewResponse>> UploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPostAsResponseAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fontFiles = default,
            global::System.Collections.Generic.IList<string>? originalFontNames = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}