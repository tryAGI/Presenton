#nullable enable

namespace Presenton
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Create Slide Layout
        /// </summary>
        /// <param name="isReconstruct">
        /// Whether the slide layout is being reconstructed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.CreateSlideLayoutResponse> CreateSlideLayoutApiV1PptTemplateSlideLayoutCreatePostAsync(

            global::Presenton.CreateSlideLayoutRequest request,
            bool? isReconstruct = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Slide Layout
        /// </summary>
        /// <param name="isReconstruct">
        /// Whether the slide layout is being reconstructed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.CreateSlideLayoutResponse> CreateSlideLayoutApiV1PptTemplateSlideLayoutCreatePostAsync(
            global::System.Guid id,
            int index,
            bool? isReconstruct = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}