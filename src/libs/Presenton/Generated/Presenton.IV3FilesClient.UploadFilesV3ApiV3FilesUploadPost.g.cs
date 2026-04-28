#nullable enable

namespace Presenton
{
    public partial interface IV3FilesClient
    {
        /// <summary>
        /// Upload Files V3<br/>
        /// Upload files to be used later.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> UploadFilesV3ApiV3FilesUploadPostAsync(

            global::Presenton.BodyUploadFilesV3ApiV3FilesUploadPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Files V3<br/>
        /// Upload files to be used later.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="files"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> UploadFilesV3ApiV3FilesUploadPostAsync(
            global::System.Collections.Generic.IList<byte[]>? files = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}