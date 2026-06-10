#nullable enable

namespace Presenton
{
    public partial interface IThemesClient
    {
        /// <summary>
        /// Create a user theme<br/>
        /// Creates a custom presentation theme for the authenticated user. The request body must include a name, description, and complete theme data with colors and fonts. Optionally pass `company_name` and a `logo` image asset id; the logo must already exist.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationThemeResponse> CreateThemeApiV1PptThemesCreatePostAsync(

            global::Presenton.BodyCreateThemeApiV1PptThemesCreatePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user theme<br/>
        /// Creates a custom presentation theme for the authenticated user. The request body must include a name, description, and complete theme data with colors and fonts. Optionally pass `company_name` and a `logo` image asset id; the logo must already exist.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.PresentationThemeResponse>> CreateThemeApiV1PptThemesCreatePostAsResponseAsync(

            global::Presenton.BodyCreateThemeApiV1PptThemesCreatePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user theme<br/>
        /// Creates a custom presentation theme for the authenticated user. The request body must include a name, description, and complete theme data with colors and fonts. Optionally pass `company_name` and a `logo` image asset id; the logo must already exist.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="data"></param>
        /// <param name="companyName"></param>
        /// <param name="logo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationThemeResponse> CreateThemeApiV1PptThemesCreatePostAsync(
            string name,
            string description,
            global::Presenton.PresentionThemeDataInput data,
            string? companyName = default,
            global::System.Guid? logo = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}