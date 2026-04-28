#nullable enable

namespace Presenton
{
    public partial interface IV2SlideClient
    {
        /// <summary>
        /// Generate New Slide<br/>
        /// Generate a new slide for a presentation using a user prompt. Does not persist to DB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GenerateSlideResponse> GenerateNewSlideApiV2PptSlideGeneratePostAsync(

            global::Presenton.GenerateSlideRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate New Slide<br/>
        /// Generate a new slide for a presentation using a user prompt. Does not persist to DB.
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="prompt"></param>
        /// <param name="qualitativechart"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GenerateSlideResponse> GenerateNewSlideApiV2PptSlideGeneratePostAsync(
            global::System.Guid presentationId,
            string prompt,
            global::Presenton.QualitativeChart? qualitativechart = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}