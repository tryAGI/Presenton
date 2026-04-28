#nullable enable

namespace Presenton
{
    public partial interface IV3PresentationClient
    {
        /// <summary>
        /// Export Presentation As Pptx Or Pdf V3<br/>
        /// Export a presentation as PPTX, PDF or PNG.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationPathAndEditPath> ExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostAsync(

            global::Presenton.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Presentation As Pptx Or Pdf V3<br/>
        /// Export a presentation as PPTX, PDF or PNG.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id">
        /// Presentation ID to export
        /// </param>
        /// <param name="exportAs">
        /// Format to export the presentation as
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationPathAndEditPath> ExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostAsync(
            global::System.Guid id,
            global::Presenton.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs exportAs,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}