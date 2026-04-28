#nullable enable

namespace Presenton
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Generate Images
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="imageType">
        /// Default Value: stock
        /// </param>
        /// <param name="count">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateImagesApiV2PptImagesGenerateGetAsync(
            string prompt,
            global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType? imageType = default,
            int? count = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}