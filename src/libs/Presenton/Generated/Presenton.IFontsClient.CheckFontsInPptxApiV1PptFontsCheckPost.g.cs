#nullable enable

namespace Presenton
{
    public partial interface IFontsClient
    {
        /// <summary>
        /// Check Fonts In Pptx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontCheckResponse> CheckFontsInPptxApiV1PptFontsCheckPostAsync(

            global::Presenton.BodyCheckFontsInPptxApiV1PptFontsCheckPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Fonts In Pptx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontCheckResponse>> CheckFontsInPptxApiV1PptFontsCheckPostAsResponseAsync(

            global::Presenton.BodyCheckFontsInPptxApiV1PptFontsCheckPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Fonts In Pptx
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontCheckResponse> CheckFontsInPptxApiV1PptFontsCheckPostAsync(
            byte[] pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check Fonts In Pptx
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.FontCheckResponse> CheckFontsInPptxApiV1PptFontsCheckPostAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Fonts In Pptx
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.FontCheckResponse>> CheckFontsInPptxApiV1PptFontsCheckPostAsResponseAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}