#nullable enable

namespace Presenton
{
    public partial interface IMockClient
    {
        /// <summary>
        /// Mock Presentation Generation Completed
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Presenton.PresentationPathAndEditPath>> MockPresentationGenerationCompletedApiV1MockPresentationGenerationCompletedGetAsync(
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}