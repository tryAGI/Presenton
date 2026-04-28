#nullable enable

namespace Presenton
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Generate Image
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="imageType">
        /// Default Value: stock
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateImageApiV1PptImagesGenerateGetAsync(
            string prompt,
            global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType? imageType = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}