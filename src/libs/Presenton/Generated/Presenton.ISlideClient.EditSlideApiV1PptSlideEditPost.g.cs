#nullable enable

namespace Presenton
{
    public partial interface ISlideClient
    {
        /// <summary>
        /// Edit Slide<br/>
        /// Edit a slide with a prompt.<br/>
        /// Usage options:<br/>
        /// - Provide `id` + `prompt` to edit a specific slide by id.<br/>
        /// - Provide `presentation_id` + `prompt` to edit by presentation. You can also<br/>
        ///   pass `slide_index` to target a specific slide; if omitted, the index is<br/>
        ///   inferred from the prompt.<br/>
        /// - Provide `export_as` to export the edited presentation as `pptx` or `pdf`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AnyOf<global::Presenton.PresentationPathAndEditPath, global::Presenton.SlideModel>> EditSlideApiV1PptSlideEditPostAsync(

            global::Presenton.EditSlideRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Slide<br/>
        /// Edit a slide with a prompt.<br/>
        /// Usage options:<br/>
        /// - Provide `id` + `prompt` to edit a specific slide by id.<br/>
        /// - Provide `presentation_id` + `prompt` to edit by presentation. You can also<br/>
        ///   pass `slide_index` to target a specific slide; if omitted, the index is<br/>
        ///   inferred from the prompt.<br/>
        /// - Provide `export_as` to export the edited presentation as `pptx` or `pdf`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.AnyOf<global::Presenton.PresentationPathAndEditPath, global::Presenton.SlideModel>>> EditSlideApiV1PptSlideEditPostAsResponseAsync(

            global::Presenton.EditSlideRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Slide<br/>
        /// Edit a slide with a prompt.<br/>
        /// Usage options:<br/>
        /// - Provide `id` + `prompt` to edit a specific slide by id.<br/>
        /// - Provide `presentation_id` + `prompt` to edit by presentation. You can also<br/>
        ///   pass `slide_index` to target a specific slide; if omitted, the index is<br/>
        ///   inferred from the prompt.<br/>
        /// - Provide `export_as` to export the edited presentation as `pptx` or `pdf`.
        /// </summary>
        /// <param name="id">
        /// The id of the slide to edit
        /// </param>
        /// <param name="presentationId">
        /// The id of the presentation to edit
        /// </param>
        /// <param name="slideIndex">
        /// The index of the slide to edit
        /// </param>
        /// <param name="prompt">
        /// The prompt to edit the slide
        /// </param>
        /// <param name="exportAs">
        /// The format to export the presentation as<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AnyOf<global::Presenton.PresentationPathAndEditPath, global::Presenton.SlideModel>> EditSlideApiV1PptSlideEditPostAsync(
            string prompt,
            global::System.Guid? id = default,
            global::System.Guid? presentationId = default,
            int? slideIndex = default,
            global::Presenton.EditSlideRequestExportAs2? exportAs = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}