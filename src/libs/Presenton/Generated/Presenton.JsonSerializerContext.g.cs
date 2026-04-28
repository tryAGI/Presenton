
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Presenton.JsonConverters.AsyncTaskStatusJsonConverter),

            typeof(global::Presenton.JsonConverters.AsyncTaskStatusNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyCreatePresentationApiV1PptPresentationCreatePostImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyCreatePresentationApiV1PptPresentationCreatePostImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyPresentationExportApiV1OnPresentationExportPostExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyPresentationExportApiV1OnPresentationExportPostExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyPresentationExportApiV2OnPresentationExportPostExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.BodyPresentationExportApiV2OnPresentationExportPostExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.ContentGenerationModeJsonConverter),

            typeof(global::Presenton.JsonConverters.ContentGenerationModeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.CreatePresentationFromJsonRequestV1ExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.CreatePresentationFromJsonRequestV1ExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.CreatePresentationFromJsonRequestV3ExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.CreatePresentationFromJsonRequestV3ExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.DeviceJsonConverter),

            typeof(global::Presenton.JsonConverters.DeviceNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.DownloadFormatJsonConverter),

            typeof(global::Presenton.JsonConverters.DownloadFormatNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.EditPresentationRequestExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.EditPresentationRequestExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.EditSlideRequestExportAs2JsonConverter),

            typeof(global::Presenton.JsonConverters.EditSlideRequestExportAs2NullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateContentForSchemaRequestModeJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateContentForSchemaRequestModeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateHTMLPresentationRequestV2ImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateHTMLPresentationRequestV2ImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV1ImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV1ImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV1ExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV1ExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV2ImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV2ImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV2ExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV2ExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV3ImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV3ImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV3ExportAsJsonConverter),

            typeof(global::Presenton.JsonConverters.GeneratePresentationRequestV3ExportAsNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.QualitativeChartJsonConverter),

            typeof(global::Presenton.JsonConverters.QualitativeChartNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.ToneJsonConverter),

            typeof(global::Presenton.JsonConverters.ToneNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.VerbosityJsonConverter),

            typeof(global::Presenton.JsonConverters.VerbosityNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.WebhookEventJsonConverter),

            typeof(global::Presenton.JsonConverters.WebhookEventNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateImageApiV1PptImagesGenerateGetImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateImageApiV1PptImagesGenerateGetImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateImagesApiV2PptImagesGenerateGetImageTypeJsonConverter),

            typeof(global::Presenton.JsonConverters.GenerateImagesApiV2PptImagesGenerateGetImageTypeNullableJsonConverter),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::Presenton.PresentationPathAndEditPath, global::Presenton.SlideModel>),

            typeof(global::Presenton.JsonConverters.AnyOfJsonConverter<global::Presenton.PresentationWithSlidesV1, global::Presenton.PresentationWithSlidesV2>),

            typeof(global::Presenton.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.APIErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AccessToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AsyncDesignExtractionTaskModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AsyncPresentationGenerationTaskModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AsyncTaskModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AsyncTaskStatus), TypeInfoPropertyName = "AsyncTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BearerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyAddCreditsApiV1DebugAddCreditsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyAddSubscriptionApiV1DebugAddSubscriptionPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyAddUserApiV1DebugAddUserPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyAuthJwtLoginApiV1AuthJwtLoginPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCheckCreditBalanceApiV1DebugCheckCreditBalancePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCheckFontsInPptxApiV1PptFontsCheckPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCheckFontsInPptxApiV2PptFontsCheckPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCreatePortalSessionApiV1BillingPortalSessionPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Tone), TypeInfoPropertyName = "Tone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Verbosity), TypeInfoPropertyName = "Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCreatePresentationApiV1PptPresentationCreatePostImageType), TypeInfoPropertyName = "BodyCreatePresentationApiV1PptPresentationCreatePostImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyCreateThemeApiV1PptThemesCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyDecomposeFilesApiV1PptFilesDecomposePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyDeleteUserApiV1DebugDeleteUserDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyEditReactWithImageEndpointApiV1PptReactEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyEditSlideHtmlApiV1PptSlideEditHtmlPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyEndSubscriptionApiV1DebugEndSubscriptionPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs), TypeInfoPropertyName = "BodyExportPresentationAsPptxOrPdfV1ApiV1PptPresentationExportPostExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs), TypeInfoPropertyName = "BodyExportPresentationAsPptxOrPdfV2ApiV2PptPresentationExportPostExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs), TypeInfoPropertyName = "BodyExportPresentationAsPptxOrPdfV3ApiV3PresentationExportPostExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyGetJwtTokenApiV1DebugGetJwtTokenPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyInitFixSlideApiV2PptFixSlideInitPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyInitHtmlCreateApiV1PptHtmlCreateInitPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyInitHtmlEditApiV1PptHtmlEditInitPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyModifySubscriptionApiV1BillingSubscriptionModifyPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyPatchMeApiV1AuthProfileUpdatePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyPreparePresentationApiV1PptPresentationPreparePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideOutlineModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideOutlineModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationLayoutModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyPresentationExportApiV1OnPresentationExportPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyPresentationExportApiV1OnPresentationExportPostExportAs), TypeInfoPropertyName = "BodyPresentationExportApiV1OnPresentationExportPostExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyPresentationExportApiV2OnPresentationExportPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyPresentationExportApiV2OnPresentationExportPostExportAs), TypeInfoPropertyName = "BodyPresentationExportApiV2OnPresentationExportPostExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyProcessPdfSlidesApiV1PptPdfSlidesProcessPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyProcessPptxFontsApiV1PptPptxFontsProcessPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyProcessPptxSlidesApiV1PptPptxSlidesProcessPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyRaiseExceptionApiV1DebugRaiseExceptionPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyResetForgotPasswordApiV1AuthForgotPasswordPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyResetResetPasswordApiV1AuthResetPasswordPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyRevokeTokenApiV1AuthTokenRevokePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodySendLowBalanceEmailApiV1DebugSendLowBalanceEmailPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodySendPasswordResetEmailApiV1DebugSendPasswordResetEmailPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodySendPaymentFailedEmailApiV1DebugSendPaymentFailedEmailPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodySendVerificationEmailApiV1DebugSendVerificationEmailPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodySendWelcomeEmailApiV1DebugSendWelcomeEmailPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyTestJobApiV1DebugTestJobPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUnsubscribeToWebhookV1ApiV1WebhookUnsubscribeDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUnsubscribeToWebhookV3ApiV3WebhookUnsubscribeDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUpdatePresentationApiV1PptPresentationUpdatePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUpdateThemeApiV1PptThemesUpdateThemeIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFilesAndGetTemporaryUrlsApiV1PptFilesUploadAndGetTemporaryUrlsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFilesForUiApiV1PptFilesUploadUiPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFilesV1ApiV1PptFilesUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFilesV3ApiV3FilesUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFontApiV1PptFontsUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFontsAndSlidesPreviewApiV1PptTemplateFontsUploadAndSlidesPreviewPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFontsAndSlidesPreviewApiV2PptFontsUploadAndPreviewPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadImageForUiApiV1PptImagesUploadUiPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadImageV1ApiV1PptImagesUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadImageV3ApiV3ImagesUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyVerifyRequestTokenApiV1AuthRequestVerifyTokenPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyVerifyVerifyApiV1AuthVerifyPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CheckCreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CloneSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CloneTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ContentGenerationMode), TypeInfoPropertyName = "ContentGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateCheckoutSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateCheckoutSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateDesignSystemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreatePortalSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreatePresentationFromJsonRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.CreateSlideFromJsonRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateSlideFromJsonRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreatePresentationFromJsonRequestV1ExportAs), TypeInfoPropertyName = "CreatePresentationFromJsonRequestV1ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreatePresentationFromJsonRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreatePresentationFromJsonRequestV3ExportAs), TypeInfoPropertyName = "CreatePresentationFromJsonRequestV3ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateSlideLayoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateTemplateInitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreditAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreditAccountWithBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreditAddTransactionRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreditsRate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreditsRatesAndAutoTopupInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TopupInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.DecomposedFileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.DefaultPresentationThemeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.DesignSystemExportInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.DesignSystemSlideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Device), TypeInfoPropertyName = "Device2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.DownloadFormat), TypeInfoPropertyName = "DownloadFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditOutlineRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditPresentationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideContentUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideContentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditPresentationRequestExportAs), TypeInfoPropertyName = "EditPresentationRequestExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSectionHTMLRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSectionHTMLResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideHTMLRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideHTMLResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutSectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideRequestExportAs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseCreditsAddResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.UserRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseCreditsAddsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.CreditAddTransactionRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseCreditsInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseLoginResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterprisePresentationRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterprisePresentationsInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterprisePresentationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.EnterprisePresentationRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserAccessTokenRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserAccessTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.EnterpriseUserAccessTokenRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserAddRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserCreditsAddRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserCreditsInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserPasswordResetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUserPresentationsInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUsersInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EnterpriseUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.UserRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "AnyOfStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ExtractDesignSystemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.DesignSystemSlideInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ExtractDesignSystemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.FontInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.FontDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontsUploadAndSlidesPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateContentForSchemaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateContentForSchemaRequestMode), TypeInfoPropertyName = "GenerateContentForSchemaRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateContentForSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateHTMLPresentationRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateHTMLPresentationRequestV2ImageType), TypeInfoPropertyName = "GenerateHTMLPresentationRequestV2ImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateHTMLPresentationResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateOutlinesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV1ImageType), TypeInfoPropertyName = "GeneratePresentationRequestV1ImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV1ExportAs), TypeInfoPropertyName = "GeneratePresentationRequestV1ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideContentLayout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV2ImageType), TypeInfoPropertyName = "GeneratePresentationRequestV2ImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV2ExportAs), TypeInfoPropertyName = "GeneratePresentationRequestV2ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3ImageType), TypeInfoPropertyName = "GeneratePresentationRequestV3ImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3ExportAs), TypeInfoPropertyName = "GeneratePresentationRequestV3ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateSlideRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.QualitativeChart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateSlideResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateThemeRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetJwtTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetLayoutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.LayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.LayoutData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>), TypeInfoPropertyName = "AnyOfIListStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetMeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetPresentationStatusResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetPresentationSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.PresentationSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetTemplateLayoutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.TemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateLayoutData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HTMLSlideV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HtmlEditInitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HtmlEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HtmlToReactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HtmlToReactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ImageAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ModifySubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.OAuth2AuthorizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.OnboardingQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PaginatedVariationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PdfSlideData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PdfSlidesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.PdfSlideData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PptxFontsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PptxSlidesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideLayoutModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideLayoutModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationPathAndEditPath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationThemeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationWithSlidesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationWithSlidesV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.HTMLSlideV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PriceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PurchaseCreditsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ReactivateSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveLayoutsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveLayoutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveTemplateLayoutData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SegmentVariationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideToHtmlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideToHtmlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideToReactRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideToReactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SubscribeToWebhookRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.WebhookEvent), TypeInfoPropertyName = "WebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SubscribeToWebhookResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateExampleV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ThemeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.UpdatePresentationRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.UpdateTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.UserCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.UserUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.VariationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateImageApiV1PptImagesGenerateGetImageType), TypeInfoPropertyName = "GenerateImageApiV1PptImagesGenerateGetImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GenerateImagesApiV2PptImagesGenerateGetImageType), TypeInfoPropertyName = "GenerateImagesApiV2PptImagesGenerateGetImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.AccessToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.DecomposedFileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.TemplateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::Presenton.PresentationPathAndEditPath, global::Presenton.SlideModel>), TypeInfoPropertyName = "AnyOfPresentationPathAndEditPathSlideModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.DefaultPresentationThemeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.PresentationThemeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.PriceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.PresentationPathAndEditPath>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.APIErrorModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.OnboardingQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::Presenton.PresentationWithSlidesV1, global::Presenton.PresentationWithSlidesV2>), TypeInfoPropertyName = "AnyOfPresentationWithSlidesV1PresentationWithSlidesV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SubscribeToWebhookResponseV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideOutlineModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.CreateSlideFromJsonRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideContentUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.CreditAddTransactionRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.EnterprisePresentationRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.EnterpriseUserAccessTokenRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.UserRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.DesignSystemSlideInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.FontInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.FontDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideContentLayout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.LayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::System.Collections.Generic.List<string>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.PresentationSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.TemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.PdfSlideData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideLayoutModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.HTMLSlideV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SaveTemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.AccessToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.DecomposedFileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.TemplateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.DefaultPresentationThemeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.PresentationThemeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.PriceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.PresentationPathAndEditPath>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.APIErrorModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.OnboardingQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SubscribeToWebhookResponseV1>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}