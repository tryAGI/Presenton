#nullable enable

namespace Presenton
{
    public partial interface IV2FontsClient
    {
        /// <summary>
        /// Check Fonts In Pptx Handler<br/>
        /// Extract fonts from a PPTX file and check their availability in Google Fonts.<br/>
        /// Returns:<br/>
        ///     FontCheckResponse with available and unavailable fonts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontCheckResponse> CheckFontsInPptxHandlerApiV2PptFontsCheckPostAsync(

            global::Presenton.BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Fonts In Pptx Handler<br/>
        /// Extract fonts from a PPTX file and check their availability in Google Fonts.<br/>
        /// Returns:<br/>
        ///     FontCheckResponse with available and unavailable fonts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontCheckResponse>> CheckFontsInPptxHandlerApiV2PptFontsCheckPostAsResponseAsync(

            global::Presenton.BodyCheckFontsInPptxHandlerApiV2PptFontsCheckPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Fonts In Pptx Handler<br/>
        /// Extract fonts from a PPTX file and check their availability in Google Fonts.<br/>
        /// Returns:<br/>
        ///     FontCheckResponse with available and unavailable fonts
        /// </summary>
        /// <param name="pptxFile"></param>
        /// <param name="pptxFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontCheckResponse> CheckFontsInPptxHandlerApiV2PptFontsCheckPostAsync(
            byte[] pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check Fonts In Pptx Handler<br/>
        /// Extract fonts from a PPTX file and check their availability in Google Fonts.<br/>
        /// Returns:<br/>
        ///     FontCheckResponse with available and unavailable fonts
        /// </summary>
        /// <param name="pptxFile">
        /// The stream to send as the multipart 'pptx_file' file part.
        /// </param>
        /// <param name="pptxFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontCheckResponse> CheckFontsInPptxHandlerApiV2PptFontsCheckPostAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Fonts In Pptx Handler<br/>
        /// Extract fonts from a PPTX file and check their availability in Google Fonts.<br/>
        /// Returns:<br/>
        ///     FontCheckResponse with available and unavailable fonts
        /// </summary>
        /// <param name="pptxFile">
        /// The stream to send as the multipart 'pptx_file' file part.
        /// </param>
        /// <param name="pptxFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontCheckResponse>> CheckFontsInPptxHandlerApiV2PptFontsCheckPostAsResponseAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}