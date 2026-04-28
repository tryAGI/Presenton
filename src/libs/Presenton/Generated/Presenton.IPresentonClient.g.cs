
#nullable enable

namespace Presenton
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPresentonClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Presenton.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Presenton.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public CreditClient Credit { get; }

        /// <summary>
        /// 
        /// </summary>
        public DebugClient Debug { get; }

        /// <summary>
        /// 
        /// </summary>
        public DesignSystemClient DesignSystem { get; }

        /// <summary>
        /// 
        /// </summary>
        public DownloadsClient Downloads { get; }

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public FontsClient Fonts { get; }

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health { get; }

        /// <summary>
        /// 
        /// </summary>
        public HtmlCreateClient HtmlCreate { get; }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditClient HtmlEdit { get; }

        /// <summary>
        /// 
        /// </summary>
        public HtmlToReactClient HtmlToReact { get; }

        /// <summary>
        /// 
        /// </summary>
        public IconsClient Icons { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// 
        /// </summary>
        public MockClient Mock { get; }

        /// <summary>
        /// 
        /// </summary>
        public OutlinesClient Outlines { get; }

        /// <summary>
        /// 
        /// </summary>
        public PdfSlidesClient PdfSlides { get; }

        /// <summary>
        /// 
        /// </summary>
        public PptxFontsClient PptxFonts { get; }

        /// <summary>
        /// 
        /// </summary>
        public PptxSlidesClient PptxSlides { get; }

        /// <summary>
        /// 
        /// </summary>
        public PresentationClient Presentation { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReactEditClient ReactEdit { get; }

        /// <summary>
        /// 
        /// </summary>
        public SlideClient Slide { get; }

        /// <summary>
        /// 
        /// </summary>
        public SlideToHtmlClient SlideToHtml { get; }

        /// <summary>
        /// 
        /// </summary>
        public SlideToReactClient SlideToReact { get; }

        /// <summary>
        /// 
        /// </summary>
        public TemplateClient Template { get; }

        /// <summary>
        /// 
        /// </summary>
        public TemplateManagementClient TemplateManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public ThemesClient Themes { get; }

        /// <summary>
        /// 
        /// </summary>
        public V1OnClient V1On { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2DesignClient V2Design { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2FixSlideClient V2FixSlide { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2FontsClient V2Fonts { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2OnClient V2On { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2OnboardingClient V2Onboarding { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2PresentationClient V2Presentation { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2SlideClient V2Slide { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3AsyncTaskClient V3AsyncTask { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3EnterpriseClient V3Enterprise { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3FilesClient V3Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3GitHubClient V3GitHub { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3ImagesClient V3Images { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3PlaygroundClient V3Playground { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3PresentationClient V3Presentation { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3SchemaClient V3Schema { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3SmartDesignClient V3SmartDesign { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3StandardTemplateClient V3StandardTemplate { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3ThemeClient V3Theme { get; }

        /// <summary>
        /// 
        /// </summary>
        public V3WebhookClient V3Webhook { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhookClient Webhook { get; }

    }
}