#nullable enable

namespace Presenton
{
    public partial interface IV2SlideClient
    {
        /// <summary>
        /// Generate Segment Variations<br/>
        /// Generate alternative code segments using Zai and return full slide variations. Persist them on the slide.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.VariationsResponse> GenerateSegmentVariationsApiV2PptSlideIdSegmentVariationsGeneratePostAsync(
            global::System.Guid id,

            global::Presenton.SegmentVariationsRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Segment Variations<br/>
        /// Generate alternative code segments using Zai and return full slide variations. Persist them on the slide.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="segmentCode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.VariationsResponse> GenerateSegmentVariationsApiV2PptSlideIdSegmentVariationsGeneratePostAsync(
            global::System.Guid id,
            string segmentCode,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}