#nullable enable

namespace Presenton
{
    public partial interface IV3PresentationClient
    {
        /// <summary>
        /// Create Presentation From Json Sync V3<br/>
        /// Create a presentation from JSON synchronously.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationPathAndEditPath> CreatePresentationFromJsonSyncV3ApiV3PresentationFromJsonPostAsync(

            global::Presenton.CreatePresentationFromJsonRequestV3 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Presentation From Json Sync V3<br/>
        /// Create a presentation from JSON synchronously.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PresentationPathAndEditPath>> CreatePresentationFromJsonSyncV3ApiV3PresentationFromJsonPostAsResponseAsync(

            global::Presenton.CreatePresentationFromJsonRequestV3 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Presentation From Json Sync V3<br/>
        /// Create a presentation from JSON synchronously.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="language">
        /// The language of the presentation<br/>
        /// Default Value: English
        /// </param>
        /// <param name="title">
        /// The title of the presentation
        /// </param>
        /// <param name="standardTemplate">
        /// The template to use for the presentation. Available templates: neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift and your custom templates<br/>
        /// Default Value: general
        /// </param>
        /// <param name="theme">
        /// The theme to use for the presentation. Available themes: edge-yellow, light-rose, mint-blue, professional-blue, professional-dark and your custom themes
        /// </param>
        /// <param name="slides">
        /// The slides to use for the presentation<br/>
        /// Default Value: []
        /// </param>
        /// <param name="exportAs">
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="triggerWebhook">
        /// Whether to trigger subscribed webhooks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationPathAndEditPath> CreatePresentationFromJsonSyncV3ApiV3PresentationFromJsonPostAsync(
            string? language = default,
            string? title = default,
            string? standardTemplate = default,
            string? theme = default,
            global::System.Collections.Generic.IList<global::Presenton.CreateSlideFromJsonRequestV1>? slides = default,
            global::Presenton.CreatePresentationFromJsonRequestV3ExportAs? exportAs = default,
            bool? triggerWebhook = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}