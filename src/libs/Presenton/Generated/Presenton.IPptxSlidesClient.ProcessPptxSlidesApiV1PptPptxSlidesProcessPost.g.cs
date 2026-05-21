#nullable enable

namespace Presenton
{
    public partial interface IPptxSlidesClient
    {
        /// <summary>
        /// Process Pptx Slides<br/>
        /// Process a PPTX file to extract slide screenshots and XML content.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PPTX file<br/>
        /// 2. Installs any provided font files<br/>
        /// 3. Unzips the PPTX to extract slide XMLs<br/>
        /// 4. Uses LibreOffice to generate slide screenshots<br/>
        /// 5. Returns both screenshot URLs and XML content for each slide
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PptxSlidesResponse> ProcessPptxSlidesApiV1PptPptxSlidesProcessPostAsync(

            global::Presenton.BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process Pptx Slides<br/>
        /// Process a PPTX file to extract slide screenshots and XML content.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PPTX file<br/>
        /// 2. Installs any provided font files<br/>
        /// 3. Unzips the PPTX to extract slide XMLs<br/>
        /// 4. Uses LibreOffice to generate slide screenshots<br/>
        /// 5. Returns both screenshot URLs and XML content for each slide
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PptxSlidesResponse>> ProcessPptxSlidesApiV1PptPptxSlidesProcessPostAsResponseAsync(

            global::Presenton.BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process Pptx Slides<br/>
        /// Process a PPTX file to extract slide screenshots and XML content.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PPTX file<br/>
        /// 2. Installs any provided font files<br/>
        /// 3. Unzips the PPTX to extract slide XMLs<br/>
        /// 4. Uses LibreOffice to generate slide screenshots<br/>
        /// 5. Returns both screenshot URLs and XML content for each slide
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to process
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to process
        /// </param>
        /// <param name="fonts">
        /// Optional font files
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PptxSlidesResponse> ProcessPptxSlidesApiV1PptPptxSlidesProcessPostAsync(
            byte[] pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fonts = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Process Pptx Slides<br/>
        /// Process a PPTX file to extract slide screenshots and XML content.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PPTX file<br/>
        /// 2. Installs any provided font files<br/>
        /// 3. Unzips the PPTX to extract slide XMLs<br/>
        /// 4. Uses LibreOffice to generate slide screenshots<br/>
        /// 5. Returns both screenshot URLs and XML content for each slide
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to process
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to process
        /// </param>
        /// <param name="fonts">
        /// Optional font files
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PptxSlidesResponse> ProcessPptxSlidesApiV1PptPptxSlidesProcessPostAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fonts = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process Pptx Slides<br/>
        /// Process a PPTX file to extract slide screenshots and XML content.<br/>
        /// This endpoint:<br/>
        /// 1. Validates the uploaded PPTX file<br/>
        /// 2. Installs any provided font files<br/>
        /// 3. Unzips the PPTX to extract slide XMLs<br/>
        /// 4. Uses LibreOffice to generate slide screenshots<br/>
        /// 5. Returns both screenshot URLs and XML content for each slide
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to process
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to process
        /// </param>
        /// <param name="fonts">
        /// Optional font files
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PptxSlidesResponse>> ProcessPptxSlidesApiV1PptPptxSlidesProcessPostAsResponseAsync(
            global::System.IO.Stream pptxFile,
            string pptxFilename,
            global::System.Collections.Generic.IList<byte[]>? fonts = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}