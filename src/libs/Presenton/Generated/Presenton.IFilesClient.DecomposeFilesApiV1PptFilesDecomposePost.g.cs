#nullable enable

namespace Presenton
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Decompose Files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Presenton.DecomposedFileInfo>> DecomposeFilesApiV1PptFilesDecomposePostAsync(

            global::Presenton.BodyDecomposeFilesApiV1PptFilesDecomposePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decompose Files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Presenton.DecomposedFileInfo>>> DecomposeFilesApiV1PptFilesDecomposePostAsResponseAsync(

            global::Presenton.BodyDecomposeFilesApiV1PptFilesDecomposePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decompose Files
        /// </summary>
        /// <param name="filePaths"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Presenton.DecomposedFileInfo>> DecomposeFilesApiV1PptFilesDecomposePostAsync(
            global::System.Collections.Generic.IList<string> filePaths,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}