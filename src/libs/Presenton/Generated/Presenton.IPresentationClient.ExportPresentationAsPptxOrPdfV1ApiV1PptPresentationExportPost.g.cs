#nullable enable

namespace Presenton
{
    public partial interface IPresentationClient
    {
        /// <summary>
        /// Export Presentation As Pptx Or Pdf V1<br/>
        /// Export presentation as PPTX, PDF or PNG using API.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationPathAndEditPath> ExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostAsync(

            global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Presentation As Pptx Or Pdf V1<br/>
        /// Export presentation as PPTX, PDF or PNG using API.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PresentationPathAndEditPath>> ExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostAsResponseAsync(

            global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Presentation As Pptx Or Pdf V1<br/>
        /// Export presentation as PPTX, PDF or PNG using API.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id">
        /// Presentation ID to export
        /// </param>
        /// <param name="exportAs">
        /// Format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationPathAndEditPath> ExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostAsync(
            global::System.Guid id,
            global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs? exportAs = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}