#nullable enable

namespace Presenton
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload Files And Get Temporary Urls
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> UploadFilesAndGetTemporaryUrlsApiV1PptFilesUploadAndGetTemporaryUrlsPostAsync(

            global::Presenton.BodyUploadFilesAndGetTemporaryUrlsApiV1PptFilesUploadAndGetTemporaryUrlsPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Files And Get Temporary Urls
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::System.Collections.Generic.IList<string>>> UploadFilesAndGetTemporaryUrlsApiV1PptFilesUploadAndGetTemporaryUrlsPostAsResponseAsync(

            global::Presenton.BodyUploadFilesAndGetTemporaryUrlsApiV1PptFilesUploadAndGetTemporaryUrlsPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Files And Get Temporary Urls
        /// </summary>
        /// <param name="files"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> UploadFilesAndGetTemporaryUrlsApiV1PptFilesUploadAndGetTemporaryUrlsPostAsync(
            global::System.Collections.Generic.IList<byte[]>? files = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}