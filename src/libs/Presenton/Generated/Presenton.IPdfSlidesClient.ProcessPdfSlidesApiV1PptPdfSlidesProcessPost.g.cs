#nullable enable

namespace Presenton
{
    public partial interface IPdfSlidesClient
    {
        /// <summary>
        /// Process Pdf Slides<br/>
        /// Process a PDF file to extract slide screenshots.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PDF file<br/>
        /// 2. Uses ImageMagick to convert PDF pages to PNG images<br/>
        /// 3. Returns screenshot URLs for each slide/page<br/>
        /// Note: Font installation is not needed since PDFs already have fonts embedded.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PdfSlidesResponse> ProcessPdfSlidesApiV1PptPdfSlidesProcessPostAsync(

            global::Presenton.BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process Pdf Slides<br/>
        /// Process a PDF file to extract slide screenshots.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PDF file<br/>
        /// 2. Uses ImageMagick to convert PDF pages to PNG images<br/>
        /// 3. Returns screenshot URLs for each slide/page<br/>
        /// Note: Font installation is not needed since PDFs already have fonts embedded.
        /// </summary>
        /// <param name="pdfFile">
        /// PDF file to process
        /// </param>
        /// <param name="pdfFilename">
        /// PDF file to process
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PdfSlidesResponse> ProcessPdfSlidesApiV1PptPdfSlidesProcessPostAsync(
            byte[] pdfFile,
            string pdfFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}