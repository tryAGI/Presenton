#nullable enable

namespace Presenton
{
    public partial interface IPptxFontsClient
    {
        /// <summary>
        /// Process Pptx Fonts<br/>
        /// Analyze a PPTX file and return only the fonts used in the document.<br/>
        /// Uses the exact same font extraction and analysis utilities as the /pptx-slides endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PptxFontsResponse> ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync(

            global::Presenton.BodyProcessPptxFontsApiV1PptPptxFontsProcessPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process Pptx Fonts<br/>
        /// Analyze a PPTX file and return only the fonts used in the document.<br/>
        /// Uses the exact same font extraction and analysis utilities as the /pptx-slides endpoint.
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
        global::System.Threading.Tasks.Task<global::Presenton.PptxFontsResponse> ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync(
            byte[] pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}